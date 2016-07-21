using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProp3DButtonRepresentation : vtkButtonRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DButtonRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkProp3DButtonRepresentation()
		{
			vtkProp3DButtonRepresentation.MRClassNameKey = "class vtkProp3DButtonRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3DButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DButtonRepresentation"));
		}

		public vtkProp3DButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3DButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProp3DButtonRepresentation New()
		{
			vtkProp3DButtonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProp3DButtonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

		public virtual void FollowCameraOff()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_FollowCameraOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

		public virtual void FollowCameraOn()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_FollowCameraOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetActors_05(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3DButtonRepresentation_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3DButtonRepresentation_GetButtonProp_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp3D GetButtonProp(int i)
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetButtonProp_07(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_GetFollowCamera_08(HandleRef pThis);

		public virtual int GetFollowCamera()
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetFollowCamera_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_09(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3DButtonRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProp3DButtonRepresentation NewInstance()
		{
			vtkProp3DButtonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_PlaceWidget_14(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_PlaceWidget_14(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ReleaseGraphicsResources_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderOpaqueGeometry_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkProp3DButtonRepresentation_RenderVolumetricGeometry_18(HandleRef pThis, HandleRef arg0);

		public override int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderVolumetricGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3DButtonRepresentation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProp3DButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkProp3DButtonRepresentation vtkProp3DButtonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DButtonRepresentation = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DButtonRepresentation.Register(null);
				}
			}
			return vtkProp3DButtonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_SetButtonProp_20(HandleRef pThis, int i, HandleRef prop);

		public void SetButtonProp(int i, vtkProp3D prop)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetButtonProp_20(base.GetCppThis(), i, (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_SetFollowCamera_21(HandleRef pThis, int _arg);

		public virtual void SetFollowCamera(int _arg)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetFollowCamera_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_SetState_22(HandleRef pThis, int state);

		public override void SetState(int state)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetState_22(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkProp3DButtonRepresentation_ShallowCopy_23(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ShallowCopy_23(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
