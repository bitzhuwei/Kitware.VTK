using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleRubberBandPick : vtkInteractorStyleTrackballCamera
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandPick";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleRubberBandPick()
		{
			vtkInteractorStyleRubberBandPick.MRClassNameKey = "class vtkInteractorStyleRubberBandPick";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBandPick.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandPick"));
		}

		public vtkInteractorStyleRubberBandPick(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBandPick New()
		{
			vtkInteractorStyleRubberBandPick result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleRubberBandPick() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBandPick_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBandPick_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleRubberBandPick NewInstance()
		{
			vtkInteractorStyleRubberBandPick result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandPick_OnChar_05(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnChar_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonDown_06(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnLeftButtonDown_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonUp_07(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnLeftButtonUp_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandPick_OnMouseMove_08(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnMouseMove_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBandPick SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBandPick vtkInteractorStyleRubberBandPick = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBandPick = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBandPick.Register(null);
				}
			}
			return vtkInteractorStyleRubberBandPick;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBandPick_StartSelect_10(HandleRef pThis);

		public void StartSelect()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_StartSelect_10(base.GetCppThis());
		}
	}
}
