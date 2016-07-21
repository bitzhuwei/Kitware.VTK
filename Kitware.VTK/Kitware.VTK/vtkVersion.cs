using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVersion : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVersion";

		public new static readonly string MRClassNameKey;

		static vtkVersion()
		{
			vtkVersion.MRClassNameKey = "class vtkVersion";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVersion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVersion"));
		}

		public vtkVersion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVersion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVersion New()
		{
			vtkVersion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVersion.vtkVersion_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVersion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVersion() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVersion.vtkVersion_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVersion_GetVTKBuildVersion_01();

		public static int GetVTKBuildVersion()
		{
			return vtkVersion.vtkVersion_GetVTKBuildVersion_01();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVersion_GetVTKMajorVersion_02();

		public static int GetVTKMajorVersion()
		{
			return vtkVersion.vtkVersion_GetVTKMajorVersion_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVersion_GetVTKMinorVersion_03();

		public static int GetVTKMinorVersion()
		{
			return vtkVersion.vtkVersion_GetVTKMinorVersion_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVersion_GetVTKSourceVersion_04();

		public static string GetVTKSourceVersion()
		{
			return Marshal.PtrToStringAnsi(vtkVersion.vtkVersion_GetVTKSourceVersion_04());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVersion_GetVTKVersion_05();

		public static string GetVTKVersion()
		{
			return Marshal.PtrToStringAnsi(vtkVersion.vtkVersion_GetVTKVersion_05());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVersion_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVersion.vtkVersion_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVersion_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVersion.vtkVersion_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVersion_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVersion NewInstance()
		{
			vtkVersion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVersion.vtkVersion_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVersion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVersion_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVersion SafeDownCast(vtkObjectBase o)
		{
			vtkVersion vtkVersion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVersion.vtkVersion_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVersion = (vtkVersion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVersion.Register(null);
				}
			}
			return vtkVersion;
		}
	}
}
