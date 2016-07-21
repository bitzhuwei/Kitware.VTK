using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGarbageCollector : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGarbageCollector";

		public new static readonly string MRClassNameKey;

		static vtkGarbageCollector()
		{
			vtkGarbageCollector.MRClassNameKey = "class vtkGarbageCollector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGarbageCollector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGarbageCollector"));
		}

		public vtkGarbageCollector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGarbageCollector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGarbageCollector New()
		{
			vtkGarbageCollector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGarbageCollector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGarbageCollector.vtkGarbageCollector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGarbageCollector_Collect_01();

		public static void Collect()
		{
			vtkGarbageCollector.vtkGarbageCollector_Collect_01();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGarbageCollector_Collect_02(HandleRef root);

		public static void Collect(vtkObjectBase root)
		{
			vtkGarbageCollector.vtkGarbageCollector_Collect_02((root == null) ? default(HandleRef) : root.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGarbageCollector_DeferredCollectionPop_03();

		public static void DeferredCollectionPop()
		{
			vtkGarbageCollector.vtkGarbageCollector_DeferredCollectionPop_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGarbageCollector_DeferredCollectionPush_04();

		public static void DeferredCollectionPush()
		{
			vtkGarbageCollector.vtkGarbageCollector_DeferredCollectionPush_04();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGarbageCollector_GetGlobalDebugFlag_05();

		public static int GetGlobalDebugFlag()
		{
			return vtkGarbageCollector.vtkGarbageCollector_GetGlobalDebugFlag_05();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGarbageCollector_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGarbageCollector_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGarbageCollector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGarbageCollector NewInstance()
		{
			vtkGarbageCollector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGarbageCollector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGarbageCollector SafeDownCast(vtkObjectBase o)
		{
			vtkGarbageCollector vtkGarbageCollector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGarbageCollector = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGarbageCollector.Register(null);
				}
			}
			return vtkGarbageCollector;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGarbageCollector_SetGlobalDebugFlag_11(int flag);

		public static void SetGlobalDebugFlag(int flag)
		{
			vtkGarbageCollector.vtkGarbageCollector_SetGlobalDebugFlag_11(flag);
		}
	}
}
