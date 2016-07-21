using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShaderCodeLibrary : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShaderCodeLibrary";

		public new static readonly string MRClassNameKey;

		static vtkShaderCodeLibrary()
		{
			vtkShaderCodeLibrary.MRClassNameKey = "class vtkShaderCodeLibrary";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShaderCodeLibrary.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderCodeLibrary"));
		}

		public vtkShaderCodeLibrary(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderCodeLibrary_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShaderCodeLibrary New()
		{
			vtkShaderCodeLibrary result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderCodeLibrary.vtkShaderCodeLibrary_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderCodeLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShaderCodeLibrary() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShaderCodeLibrary.vtkShaderCodeLibrary_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderCodeLibrary_GetShaderCode_01(string name);

		public static string GetShaderCode(string name)
		{
			return Marshal.PtrToStringAnsi(vtkShaderCodeLibrary.vtkShaderCodeLibrary_GetShaderCode_01(name));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkShaderCodeLibrary_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShaderCodeLibrary.vtkShaderCodeLibrary_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkShaderCodeLibrary_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShaderCodeLibrary.vtkShaderCodeLibrary_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderCodeLibrary_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShaderCodeLibrary NewInstance()
		{
			vtkShaderCodeLibrary result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderCodeLibrary.vtkShaderCodeLibrary_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderCodeLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkShaderCodeLibrary_RegisterShaderCode_06(string name, string code);

		public static void RegisterShaderCode(string name, string code)
		{
			vtkShaderCodeLibrary.vtkShaderCodeLibrary_RegisterShaderCode_06(name, code);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderCodeLibrary_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShaderCodeLibrary SafeDownCast(vtkObjectBase o)
		{
			vtkShaderCodeLibrary vtkShaderCodeLibrary = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderCodeLibrary.vtkShaderCodeLibrary_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderCodeLibrary = (vtkShaderCodeLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderCodeLibrary.Register(null);
				}
			}
			return vtkShaderCodeLibrary;
		}
	}
}
