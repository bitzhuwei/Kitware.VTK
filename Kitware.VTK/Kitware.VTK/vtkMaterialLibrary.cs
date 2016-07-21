using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMaterialLibrary : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaterialLibrary";

		public new static readonly string MRClassNameKey;

		static vtkMaterialLibrary()
		{
			vtkMaterialLibrary.MRClassNameKey = "class vtkMaterialLibrary";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaterialLibrary.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaterialLibrary"));
		}

		public vtkMaterialLibrary(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMaterialLibrary_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaterialLibrary New()
		{
			vtkMaterialLibrary result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaterialLibrary.vtkMaterialLibrary_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaterialLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMaterialLibrary() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMaterialLibrary.vtkMaterialLibrary_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMaterialLibrary_GetMaterial_01(string name);

		public static string GetMaterial(string name)
		{
			return Marshal.PtrToStringAnsi(vtkMaterialLibrary.vtkMaterialLibrary_GetMaterial_01(name));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkMaterialLibrary_GetNumberOfMaterials_02();

		public static uint GetNumberOfMaterials()
		{
			return vtkMaterialLibrary.vtkMaterialLibrary_GetNumberOfMaterials_02();
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMaterialLibrary_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMaterialLibrary.vtkMaterialLibrary_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMaterialLibrary_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMaterialLibrary.vtkMaterialLibrary_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMaterialLibrary_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMaterialLibrary NewInstance()
		{
			vtkMaterialLibrary result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaterialLibrary.vtkMaterialLibrary_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaterialLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMaterialLibrary_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaterialLibrary SafeDownCast(vtkObjectBase o)
		{
			vtkMaterialLibrary vtkMaterialLibrary = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaterialLibrary.vtkMaterialLibrary_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaterialLibrary = (vtkMaterialLibrary)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaterialLibrary.Register(null);
				}
			}
			return vtkMaterialLibrary;
		}
	}
}
