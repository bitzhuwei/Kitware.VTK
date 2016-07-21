using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleTrackballActor : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballActor";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleTrackballActor()
		{
			vtkInteractorStyleTrackballActor.MRClassNameKey = "class vtkInteractorStyleTrackballActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackballActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballActor"));
		}

		public vtkInteractorStyleTrackballActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackballActor New()
		{
			vtkInteractorStyleTrackballActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleTrackballActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackballActor_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackballActor_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleTrackballActor NewInstance()
		{
			vtkInteractorStyleTrackballActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonDown_06(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnLeftButtonDown_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonUp_07(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnLeftButtonUp_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonDown_08(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMiddleButtonDown_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonUp_09(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMiddleButtonUp_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonDown_11(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnRightButtonDown_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonUp_12(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_OnRightButtonUp_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_Pan_13(HandleRef pThis);

		public override void Pan()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Pan_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_Rotate_14(HandleRef pThis);

		public override void Rotate()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Rotate_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballActor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackballActor SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackballActor vtkInteractorStyleTrackballActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackballActor = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackballActor.Register(null);
				}
			}
			return vtkInteractorStyleTrackballActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_Spin_16(HandleRef pThis);

		public override void Spin()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_Spin_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballActor_UniformScale_17(HandleRef pThis);

		public override void UniformScale()
		{
			vtkInteractorStyleTrackballActor.vtkInteractorStyleTrackballActor_UniformScale_17(base.GetCppThis());
		}
	}
}
