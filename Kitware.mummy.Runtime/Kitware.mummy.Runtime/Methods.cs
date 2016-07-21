using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.mummy.Runtime
{
	public class Methods
	{
		private delegate void ObjectRefCountChangedCallback(IntPtr arg0, uint arg1, uint arg2);

		public const string RuntimeEL_dll = "Kitware.mummy.Runtime.Unmanaged.dll";

		private static Methods Instance = new Methods();

		private Hashtable WrappedObjectsTable = null;

		private uint WrappedObjectsTableHits = 0u;

		private uint WrappedObjectsTableMisses = 0u;

		private Hashtable RegisteredTypes = null;

		private Hashtable RegisteredAssemblies = null;

		private ArrayList IndexedConstructors = null;

		private Methods.ObjectRefCountChangedCallback Callback = null;

		private uint CallbackId = 4294967295u;

		private static bool TraceInternalCalls = false;

		private static bool TraceToConsoleError = true;

		private static bool TraceToConsoleOut = false;

		private static bool TraceToDebug = true;

		private Methods()
		{
		}

		~Methods()
		{
			this.ForceRemoveCallbacksImpl();
		}

		public static void Trace(string s)
		{
			if (Methods.TraceToConsoleError)
			{
				Console.Error.WriteLine(s);
			}
			if (Methods.TraceToConsoleOut)
			{
				Console.Out.WriteLine(s);
			}
			if (Methods.TraceToDebug)
			{
			}
		}

		private void Instance_ObjectRefCountChangedCallback(IntPtr rawCppThis, uint oldCount, uint newCount)
		{
			if (2u == newCount && 1u == oldCount)
			{
				this.EnsureStrongTableReference(rawCppThis);
			}
			else if (1u == newCount && 2u == oldCount)
			{
				this.EnsureWeakTableReference(rawCppThis);
			}
		}

		private void EnsureStrongTableReference(IntPtr rawCppThis)
		{
			if (null != this.WrappedObjectsTable)
			{
				lock (this.WrappedObjectsTable.SyncRoot)
				{
					if (this.WrappedObjectsTable.ContainsKey(rawCppThis))
					{
						WeakReference weakReference = this.WrappedObjectsTable[rawCppThis] as WeakReference;
						if (null != weakReference)
						{
							this.WrappedObjectsTable[rawCppThis] = weakReference.Target;
							if (Methods.TraceInternalCalls)
							{
								Methods.Trace(string.Format("rawCppThis '0x{0:x8}' converted to strong table reference", (long)rawCppThis));
							}
						}
					}
				}
			}
		}

		private void EnsureWeakTableReference(IntPtr rawCppThis)
		{
			if (null != this.WrappedObjectsTable)
			{
				lock (this.WrappedObjectsTable.SyncRoot)
				{
					if (this.WrappedObjectsTable.ContainsKey(rawCppThis))
					{
						object obj = this.WrappedObjectsTable[rawCppThis];
						WeakReference weakReference = obj as WeakReference;
						if (null == weakReference)
						{
							this.WrappedObjectsTable[rawCppThis] = new WeakReference(obj);
							if (Methods.TraceInternalCalls)
							{
								Methods.Trace(string.Format("rawCppThis '0x{0:x8}' converted to weak table reference", (long)rawCppThis));
							}
						}
					}
				}
			}
		}

		private void AddTableReferenceImpl(IntPtr rawCppThis, object obj, bool strong)
		{
			if (rawCppThis == IntPtr.Zero)
			{
				throw new Exception(string.Format("error: A 'null' rawCppThis pointer may not be used as a WrappedObjectsTable key.", new object[0]));
			}
			if (null == this.WrappedObjectsTable)
			{
				this.WrappedObjectsTable = new Hashtable();
				this.Callback = new Methods.ObjectRefCountChangedCallback(this.Instance_ObjectRefCountChangedCallback);
				this.CallbackId = Methods.AddObjectRefCountChangedCallback(this.Callback);
			}
			lock (this.WrappedObjectsTable.SyncRoot)
			{
				if (this.WrappedObjectsTable.ContainsKey(rawCppThis))
				{
					WeakReference weakReference = this.WrappedObjectsTable[rawCppThis] as WeakReference;
					if (null == weakReference)
					{
						throw new Exception(string.Format("error: Duplicate rawCppThis - existing strong reference. Attempting to add '0x{0:x8}' again.", (long)rawCppThis));
					}
					if (weakReference.IsAlive)
					{
						if (strong)
						{
							throw new Exception(string.Format("error: Duplicate rawCppThis - weak reference that is still alive. Attempting to add '0x{0:x8}' again.", (long)rawCppThis));
						}
						Methods.Trace("");
						Methods.Trace(string.Format("error: potential refcounting error: Duplicate rawCppThis - weak reference that is still alive. Attempting to add '0x{0:x8}' again.", (long)rawCppThis));
						Methods.Trace(string.Format("       Allowing new wrapped object to take over table key...", new object[0]));
						Methods.Trace(string.Format("       Original object should *not* have been destroyed while we still had it in our table without notifying us...", new object[0]));
						Methods.Trace("");
					}
				}
				if (strong)
				{
					this.WrappedObjectsTable[rawCppThis] = obj;
					if (Methods.TraceInternalCalls)
					{
						Methods.Trace(string.Format("rawCppThis '0x{0:x8}' added as strong table reference", (long)rawCppThis));
					}
				}
				else
				{
					this.WrappedObjectsTable[rawCppThis] = new WeakReference(obj);
					if (Methods.TraceInternalCalls)
					{
						Methods.Trace(string.Format("rawCppThis '0x{0:x8}' added as weak table reference", (long)rawCppThis));
					}
				}
			}
		}

		public static void AddTableReference(IntPtr rawCppThis, object obj, bool strong)
		{
			Methods.Instance.AddTableReferenceImpl(rawCppThis, obj, strong);
		}

		private void RemoveTableReferenceImpl(IntPtr rawCppThis)
		{
			if (null != this.WrappedObjectsTable)
			{
				lock (this.WrappedObjectsTable.SyncRoot)
				{
					this.WrappedObjectsTable.Remove(rawCppThis);
					if (Methods.TraceInternalCalls)
					{
						Methods.Trace(string.Format("rawCppThis '0x{0:x8}' removed", (long)rawCppThis));
					}
				}
			}
		}

		public static void RemoveTableReference(IntPtr rawCppThis)
		{
			Methods.Instance.RemoveTableReferenceImpl(rawCppThis);
		}

		[DllImport("Kitware.mummy.Runtime.Unmanaged.dll")]
		private static extern uint Kitware_mummy_Runtime_AddObjectRefCountChangedCallback(Methods.ObjectRefCountChangedCallback cb);

		private static uint AddObjectRefCountChangedCallback(Methods.ObjectRefCountChangedCallback cb)
		{
			return Methods.Kitware_mummy_Runtime_AddObjectRefCountChangedCallback(cb);
		}

		[DllImport("Kitware.mummy.Runtime.Unmanaged.dll")]
		internal static extern uint Kitware_mummy_Runtime_GetTypeEntryCount();

		public static uint GetTypeEntryCount()
		{
			return Methods.Kitware_mummy_Runtime_GetTypeEntryCount();
		}

		[DllImport("Kitware.mummy.Runtime.Unmanaged.dll")]
		internal static extern IntPtr Kitware_mummy_Runtime_GetTypeEntryClassNameKey(uint mteIndex);

		public static string GetTypeEntryClassNameKey(uint mteIndex)
		{
			return Marshal.PtrToStringAnsi(Methods.Kitware_mummy_Runtime_GetTypeEntryClassNameKey(mteIndex));
		}

		[DllImport("Kitware.mummy.Runtime.Unmanaged.dll")]
		internal static extern void Kitware_mummy_Runtime_RemoveObjectRefCountChangedCallback(uint cbid);

		private static void RemoveObjectRefCountChangedCallback(uint cbid)
		{
			Methods.Kitware_mummy_Runtime_RemoveObjectRefCountChangedCallback(cbid);
		}

		private void ForceReferenceStaticConstructors(Assembly assembly, string classNameKey)
		{
			if (Methods.TraceInternalCalls)
			{
				Methods.Trace(string.Format("Force loading types from assembly: {0}", assembly.GetName().FullName));
			}
			Type[] exportedTypes = assembly.GetExportedTypes();
			for (int i = 0; i < exportedTypes.Length; i++)
			{
				Type type = exportedTypes[i];
				if (type.IsClass)
				{
					FieldInfo field = type.GetField("MRClassNameKey");
					if (field != null && field.IsStatic)
					{
						string text = field.GetValue(null) as string;
						if (null == text)
						{
							throw new Exception(string.Format("error: could not get field value MRClassNameKey for class '{0}'.", type.Name));
						}
					}
				}
			}
		}

		private void RegisterTypeImpl(Assembly assembly, string classNameKey, Type t)
		{
			if (null == this.RegisteredAssemblies)
			{
				this.RegisteredAssemblies = new Hashtable();
			}
			if (null == this.RegisteredTypes)
			{
				this.RegisteredTypes = new Hashtable();
			}
			if (null == this.RegisteredAssemblies[assembly])
			{
				this.RegisteredAssemblies[assembly] = assembly;
				this.ForceReferenceStaticConstructors(assembly, classNameKey);
			}
			if (null != this.RegisteredTypes[classNameKey])
			{
				throw new Exception(string.Format("error: RegisterType called more than once with classNameKey='{0}'. Class key duplicated in multiple assemblies? Static initializer called more than once?", classNameKey));
			}
			this.RegisteredTypes[classNameKey] = t;
		}

		public static void RegisterType(Assembly assembly, string classNameKey, Type t)
		{
			Methods.Instance.RegisterTypeImpl(assembly, classNameKey, t);
		}

		private uint ClassNameKeyToIndex(string classNameKey)
		{
			bool flag = false;
			uint typeEntryCount = Methods.GetTypeEntryCount();
			uint num = 0u;
			uint result;
			while (!flag && num < typeEntryCount)
			{
				if (classNameKey == Methods.GetTypeEntryClassNameKey(num))
				{
					result = num;
					return result;
				}
				num += 1u;
			}
			result = 4294967295u;
			return result;
		}

		private ConstructorInfo GetConstructorInfo(uint mteIndex)
		{
			ConstructorInfo constructorInfo = null;
			if (null != this.IndexedConstructors)
			{
				if ((ulong)mteIndex < (ulong)((long)this.IndexedConstructors.Count))
				{
					constructorInfo = (ConstructorInfo)this.IndexedConstructors[(int)mteIndex];
					if (null != constructorInfo)
					{
						if (Methods.TraceInternalCalls)
						{
							Methods.Trace("info: found ci in IndexedConstructors");
						}
					}
				}
			}
			if (null == constructorInfo)
			{
				string typeEntryClassNameKey = Methods.GetTypeEntryClassNameKey(mteIndex);
				Type type = null;
				if (null != this.RegisteredTypes)
				{
					type = (Type)this.RegisteredTypes[typeEntryClassNameKey];
				}
				if (null == type)
				{
					throw new Exception(string.Format("error: could not get registered type - mteIndex='{0}' classNameKey='{1}'", mteIndex, typeEntryClassNameKey));
				}
				constructorInfo = type.GetConstructor(new Type[]
				{
					Type.GetType("System.IntPtr"),
					Type.GetType("System.Boolean"),
					Type.GetType("System.Boolean")
				});
				if (null == constructorInfo)
				{
					throw new Exception("error: expected 3 parameter constructor is unavailable - is it public?");
				}
				if (Methods.TraceInternalCalls)
				{
					Methods.Trace(string.Format("info: found ci via RegisteredTypes lookup - mteIndex: {0} - classNameKey: {1}", mteIndex, typeEntryClassNameKey));
				}
				if (null == this.IndexedConstructors)
				{
					this.IndexedConstructors = new ArrayList(128);
				}
				if ((ulong)mteIndex < (ulong)((long)this.IndexedConstructors.Count) && null != this.IndexedConstructors[(int)mteIndex])
				{
					throw new Exception(string.Format("error: IndexedConstructors table already has a non-null entry at mteIndex {0}", mteIndex));
				}
				while ((ulong)mteIndex >= (ulong)((long)this.IndexedConstructors.Count))
				{
					this.IndexedConstructors.Add(null);
				}
				this.IndexedConstructors[(int)mteIndex] = constructorInfo;
			}
			if (null == constructorInfo)
			{
				throw new Exception("error: mteIndex yields null System.Type in GetSystemType...");
			}
			return constructorInfo;
		}

		private object CreateWrappedObjectImpl(uint mteStatus, uint mteIndex, uint rawRefCount, IntPtr rawCppThis, bool callDisposalMethod, out bool created)
		{
			object obj = null;
			if (null != this.WrappedObjectsTable)
			{
				lock (this.WrappedObjectsTable.SyncRoot)
				{
					obj = this.WrappedObjectsTable[rawCppThis];
					WeakReference weakReference = obj as WeakReference;
					if (null != weakReference)
					{
						obj = weakReference.Target;
					}
				}
			}
			if (null != obj)
			{
				created = false;
				this.WrappedObjectsTableHits += 1u;
			}
			else
			{
				created = true;
				this.WrappedObjectsTableMisses += 1u;
				ConstructorInfo constructorInfo = this.GetConstructorInfo(mteIndex);
				bool flag = true;
				if (mteStatus == 0u || rawRefCount < 2u)
				{
					flag = false;
				}
				obj = constructorInfo.Invoke(new object[]
				{
					rawCppThis,
					callDisposalMethod,
					flag
				});
			}
			return obj;
		}

		public static object CreateWrappedObject(uint mteStatus, uint mteIndex, uint rawRefCount, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
		{
			return Methods.Instance.CreateWrappedObjectImpl(mteStatus, mteIndex, rawRefCount, rawCppThis, callDisposalMethod, out found);
		}

		private object CreateWrappedObjectImpl(string classNameKey, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
		{
			uint mteIndex = this.ClassNameKeyToIndex(classNameKey);
			return this.CreateWrappedObjectImpl(0u, mteIndex, 1u, rawCppThis, callDisposalMethod, out found);
		}

		public static object CreateWrappedObject(string classNameKey, IntPtr rawCppThis, bool callDisposalMethod, out bool found)
		{
			return Methods.Instance.CreateWrappedObjectImpl(classNameKey, rawCppThis, callDisposalMethod, out found);
		}

		public static string PrintIndexedConstructorsTable()
		{
			string text = "";
			if (Methods.Instance != null && null != Methods.Instance.IndexedConstructors)
			{
				text = string.Format("{0}\n  Instance.IndexedConstructors details:", text);
				text = string.Format("{0}\n    Count: {1}", text, Methods.Instance.IndexedConstructors.Count);
				int num = 0;
				lock (Methods.Instance.IndexedConstructors.SyncRoot)
				{
					foreach (ConstructorInfo arg in Methods.Instance.IndexedConstructors)
					{
						text = string.Format("{0}\n    Entry: {1}", text, num);
						text = string.Format("{0}\n         ci: {1}", text, arg);
						num++;
					}
				}
			}
			Methods.Trace(text);
			return text;
		}

		public static string PrintRegisteredAssembliesTable()
		{
			string text = "";
			if (Methods.Instance != null && null != Methods.Instance.RegisteredAssemblies)
			{
				text = string.Format("{0}\n  Instance.RegisteredAssemblies details:", text);
				text = string.Format("{0}\n    Count: {1}", text, Methods.Instance.RegisteredAssemblies.Count);
				int num = 0;
				lock (Methods.Instance.RegisteredAssemblies.SyncRoot)
				{
					foreach (DictionaryEntry dictionaryEntry in Methods.Instance.RegisteredAssemblies)
					{
						text = string.Format("{0}\n    Entry: {1}", text, num);
						text = string.Format("{0}\n        Key: {1}", text, dictionaryEntry.Key);
						text = string.Format("{0}\n      Value: {1}", text, dictionaryEntry.Value);
						num++;
					}
				}
			}
			Methods.Trace(text);
			return text;
		}

		public static string PrintRegisteredTypesTable()
		{
			string text = "";
			if (null != Methods.Instance)
			{
				if (null != Methods.Instance.RegisteredTypes)
				{
					text = string.Format("{0}\n  Instance.RegisteredTypes details:", text);
					text = string.Format("{0}\n    Count: {1}", text, Methods.Instance.RegisteredTypes.Count);
					int num = 0;
					lock (Methods.Instance.RegisteredTypes.SyncRoot)
					{
						foreach (DictionaryEntry dictionaryEntry in Methods.Instance.RegisteredTypes)
						{
							text = string.Format("{0}\n    Entry: {1}", text, num);
							text = string.Format("{0}\n        Key: {1}", text, dictionaryEntry.Key);
							text = string.Format("{0}\n      Value: {1}", text, dictionaryEntry.Value);
							num++;
						}
					}
				}
			}
			Methods.Trace(text);
			return text;
		}

		public static string PrintWrappedObjectsTable()
		{
			string text = "";
			if (Methods.Instance != null && null != Methods.Instance.WrappedObjectsTable)
			{
				text = string.Format("{0}\n  Instance.WrappedObjectsTable details:", text);
				text = string.Format("{0}\n    Count: {1}", text, Methods.Instance.WrappedObjectsTable.Count);
				int num = 0;
				lock (Methods.Instance.WrappedObjectsTable.SyncRoot)
				{
					foreach (DictionaryEntry dictionaryEntry in Methods.Instance.WrappedObjectsTable)
					{
						text = string.Format("{0}\n    Entry: {1}", text, num);
						text = string.Format("{0}\n        Key: 0x{1:x8}", text, (long)((IntPtr)dictionaryEntry.Key));
						text = string.Format("{0}\n      Value: {1}", text, dictionaryEntry.Value);
						num++;
					}
				}
			}
			Methods.Trace(text);
			return text;
		}

		public static string Print(bool details)
		{
			string text = string.Format("  Instance: {0}", Methods.Instance);
			if (null != Methods.Instance)
			{
				text = string.Format("{0}\n  Instance.WrappedObjectsTable: {1}", text, Methods.Instance.WrappedObjectsTable);
				text = string.Format("{0}\n  Instance.WrappedObjectsTableHits: {1}", text, Methods.Instance.WrappedObjectsTableHits);
				text = string.Format("{0}\n  Instance.WrappedObjectsTableMisses: {1}", text, Methods.Instance.WrappedObjectsTableMisses);
				text = string.Format("{0}\n  Instance.RegisteredTypes: {1}", text, Methods.Instance.RegisteredTypes);
				text = string.Format("{0}\n  Instance.RegisteredAssemblies: {1}", text, Methods.Instance.RegisteredAssemblies);
				text = string.Format("{0}\n  Instance.IndexedConstructors: {1}", text, Methods.Instance.IndexedConstructors);
				text = string.Format("{0}\n  Instance.CallbackId: {1}", text, Methods.Instance.CallbackId);
			}
			text = string.Format("{0}\n  TraceInternalCalls: {1}", text, Methods.TraceInternalCalls);
			text = string.Format("{0}\n  TraceToConsoleError: {1}", text, Methods.TraceToConsoleError);
			text = string.Format("{0}\n  TraceToConsoleOut: {1}", text, Methods.TraceToConsoleOut);
			text = string.Format("{0}\n  TraceToDebug: {1}", text, Methods.TraceToDebug);
			Methods.Trace(text);
			if (details)
			{
				text = string.Format("{0}\n\n{1}", text, Methods.PrintIndexedConstructorsTable());
				text = string.Format("{0}\n\n{1}", text, Methods.PrintRegisteredAssembliesTable());
				text = string.Format("{0}\n\n{1}", text, Methods.PrintRegisteredTypesTable());
				text = string.Format("{0}\n\n{1}", text, Methods.PrintWrappedObjectsTable());
			}
			return text;
		}

		public static string Print()
		{
			return Methods.Print(true);
		}

		public static bool Verify()
		{
			return true;
		}

		public static void ForceClearWrappedObjectsTable()
		{
			if (null != Methods.Instance.WrappedObjectsTable)
			{
				Methods.Instance.WrappedObjectsTable.Clear();
			}
		}

		private void ForceRemoveCallbacksImpl()
		{
			if (4294967295u != this.CallbackId)
			{
				Methods.RemoveObjectRefCountChangedCallback(this.CallbackId);
				this.Callback = null;
				this.CallbackId = 4294967295u;
			}
		}

		public static void ForceRemoveCallbacks()
		{
			Methods.Instance.ForceRemoveCallbacksImpl();
		}
	}
}
