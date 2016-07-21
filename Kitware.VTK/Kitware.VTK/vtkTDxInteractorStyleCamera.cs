using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTDxInteractorStyleCamera : vtkTDxInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleCamera";

		public new static readonly string MRClassNameKey;

		static vtkTDxInteractorStyleCamera()
		{
			vtkTDxInteractorStyleCamera.MRClassNameKey = "class vtkTDxInteractorStyleCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyleCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleCamera"));
		}

		public vtkTDxInteractorStyleCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleCamera New()
		{
			vtkTDxInteractorStyleCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTDxInteractorStyleCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleCamera_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleCamera_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTDxInteractorStyleCamera NewInstance()
		{
			vtkTDxInteractorStyleCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleCamera SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyleCamera vtkTDxInteractorStyleCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleCamera = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleCamera.Register(null);
				}
			}
			return vtkTDxInteractorStyleCamera;
		}
	}
}
