using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorMaterialHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorMaterialHelper";

		public new static readonly string MRClassNameKey;

		static vtkColorMaterialHelper()
		{
			vtkColorMaterialHelper.MRClassNameKey = "class vtkColorMaterialHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorMaterialHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorMaterialHelper"));
		}

		public vtkColorMaterialHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorMaterialHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorMaterialHelper New()
		{
			vtkColorMaterialHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorMaterialHelper.vtkColorMaterialHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorMaterialHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorMaterialHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorMaterialHelper.vtkColorMaterialHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkColorMaterialHelper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorMaterialHelper.vtkColorMaterialHelper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkColorMaterialHelper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorMaterialHelper.vtkColorMaterialHelper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorMaterialHelper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorMaterialHelper NewInstance()
		{
			vtkColorMaterialHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorMaterialHelper.vtkColorMaterialHelper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorMaterialHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkColorMaterialHelper_PrepareForRendering_05(HandleRef pThis);

		public void PrepareForRendering()
		{
			vtkColorMaterialHelper.vtkColorMaterialHelper_PrepareForRendering_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkColorMaterialHelper_Render_06(HandleRef pThis);

		public void Render()
		{
			vtkColorMaterialHelper.vtkColorMaterialHelper_Render_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorMaterialHelper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorMaterialHelper SafeDownCast(vtkObjectBase o)
		{
			vtkColorMaterialHelper vtkColorMaterialHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorMaterialHelper.vtkColorMaterialHelper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorMaterialHelper = (vtkColorMaterialHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorMaterialHelper.Register(null);
				}
			}
			return vtkColorMaterialHelper;
		}
	}
}
