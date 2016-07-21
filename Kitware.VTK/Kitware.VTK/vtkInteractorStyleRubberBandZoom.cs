using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleRubberBandZoom : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandZoom";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleRubberBandZoom()
		{
			vtkInteractorStyleRubberBandZoom.MRClassNameKey = "class vtkInteractorStyleRubberBandZoom";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBandZoom.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandZoom"));
		}

		public vtkInteractorStyleRubberBandZoom(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBandZoom New()
		{
			vtkInteractorStyleRubberBandZoom result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleRubberBandZoom() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBandZoom_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBandZoom_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleRubberBandZoom NewInstance()
		{
			vtkInteractorStyleRubberBandZoom result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_05(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_06(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandZoom_OnMouseMove_07(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_OnMouseMove_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandZoom_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBandZoom SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBandZoom vtkInteractorStyleRubberBandZoom = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandZoom.vtkInteractorStyleRubberBandZoom_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBandZoom = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBandZoom.Register(null);
				}
			}
			return vtkInteractorStyleRubberBandZoom;
		}
	}
}
