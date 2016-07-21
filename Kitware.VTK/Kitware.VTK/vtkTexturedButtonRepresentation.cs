using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTexturedButtonRepresentation : vtkButtonRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkTexturedButtonRepresentation()
		{
			vtkTexturedButtonRepresentation.MRClassNameKey = "class vtkTexturedButtonRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation"));
		}

		public vtkTexturedButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedButtonRepresentation New()
		{
			vtkTexturedButtonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTexturedButtonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

		public virtual void FollowCameraOff()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_FollowCameraOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

		public virtual void FollowCameraOn()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_FollowCameraOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetActors_05(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonGeometry_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetButtonGeometry()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetButtonGeometry_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonTexture_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetButtonTexture(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetButtonTexture_08(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_GetFollowCamera_09(HandleRef pThis);

		public virtual int GetFollowCamera()
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetFollowCamera_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetHoveringProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHoveringProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetHoveringProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetSelectingProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectingProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetSelectingProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_Highlight_14(HandleRef pThis, int state);

		public override void Highlight(int state)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_Highlight_14(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTexturedButtonRepresentation NewInstance()
		{
			vtkTexturedButtonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_19(HandleRef pThis, double scale, IntPtr point, IntPtr normal);

		public virtual void PlaceWidget(double scale, IntPtr point, IntPtr normal)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_PlaceWidget_19(base.GetCppThis(), scale, point, normal);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_20(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_PlaceWidget_20(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ReleaseGraphicsResources_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_RenderOpaqueGeometry_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedButtonRepresentation vtkTexturedButtonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedButtonRepresentation = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedButtonRepresentation.Register(null);
				}
			}
			return vtkTexturedButtonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometry_25(HandleRef pThis, HandleRef pd);

		public void SetButtonGeometry(vtkPolyData pd)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonGeometry_25(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometryConnection_26(HandleRef pThis, HandleRef algOutput);

		public void SetButtonGeometryConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonGeometryConnection_26(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonTexture_27(HandleRef pThis, int i, HandleRef image);

		public void SetButtonTexture(int i, vtkImageData image)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonTexture_27(base.GetCppThis(), i, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetFollowCamera_28(HandleRef pThis, int _arg);

		public virtual void SetFollowCamera(int _arg)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetFollowCamera_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetHoveringProperty_29(HandleRef pThis, HandleRef p);

		public virtual void SetHoveringProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetHoveringProperty_29(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetProperty_30(HandleRef pThis, HandleRef p);

		public virtual void SetProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetProperty_30(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_SetSelectingProperty_31(HandleRef pThis, HandleRef p);

		public virtual void SetSelectingProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetSelectingProperty_31(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation_ShallowCopy_32(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ShallowCopy_32(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
