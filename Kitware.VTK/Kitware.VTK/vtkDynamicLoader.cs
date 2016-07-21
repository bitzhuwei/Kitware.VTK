using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDynamicLoader : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDynamicLoader";

		public new static readonly string MRClassNameKey;

		static vtkDynamicLoader()
		{
			vtkDynamicLoader.MRClassNameKey = "class vtkDynamicLoader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDynamicLoader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDynamicLoader"));
		}

		public vtkDynamicLoader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDynamicLoader New()
		{
			vtkDynamicLoader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDynamicLoader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDynamicLoader.vtkDynamicLoader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDynamicLoader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDynamicLoader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_LastError_03();

		public static string LastError()
		{
			return Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LastError_03());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_LibExtension_04();

		public static string LibExtension()
		{
			return Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LibExtension_04());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_LibPrefix_05();

		public static string LibPrefix()
		{
			return Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LibPrefix_05());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDynamicLoader NewInstance()
		{
			vtkDynamicLoader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamicLoader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDynamicLoader SafeDownCast(vtkObjectBase o)
		{
			vtkDynamicLoader vtkDynamicLoader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDynamicLoader = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDynamicLoader.Register(null);
				}
			}
			return vtkDynamicLoader;
		}
	}
}
