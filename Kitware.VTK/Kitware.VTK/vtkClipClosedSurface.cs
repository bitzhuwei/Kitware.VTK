using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipClosedSurface : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipClosedSurface";

		public new static readonly string MRClassNameKey;

		static vtkClipClosedSurface()
		{
			vtkClipClosedSurface.MRClassNameKey = "class vtkClipClosedSurface";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipClosedSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipClosedSurface"));
		}

		public vtkClipClosedSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipClosedSurface New()
		{
			vtkClipClosedSurface result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipClosedSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipClosedSurface.vtkClipClosedSurface_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GenerateFacesOff_01(HandleRef pThis);

		public virtual void GenerateFacesOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateFacesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GenerateFacesOn_02(HandleRef pThis);

		public virtual void GenerateFacesOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateFacesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GenerateOutlineOff_03(HandleRef pThis);

		public virtual void GenerateOutlineOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateOutlineOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GenerateOutlineOn_04(HandleRef pThis);

		public virtual void GenerateOutlineOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateOutlineOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_GetActivePlaneColor_05(HandleRef pThis);

		public virtual double[] GetActivePlaneColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetActivePlaneColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetActivePlaneColor_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetActivePlaneColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetActivePlaneId_08(HandleRef pThis);

		public virtual int GetActivePlaneId()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneId_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_GetBaseColor_09(HandleRef pThis);

		public virtual double[] GetBaseColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetBaseColor_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBaseColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetBaseColor_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetBaseColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_GetClipColor_12(HandleRef pThis);

		public virtual double[] GetClipColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetClipColor_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetClipColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_GetClipColor_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetClipColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_GetClippingPlanes_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetClippingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetClippingPlanes_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetGenerateFaces_16(HandleRef pThis);

		public virtual int GetGenerateFaces()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetGenerateFaces_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetGenerateOutline_17(HandleRef pThis);

		public virtual int GetGenerateOutline()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetGenerateOutline_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetPassPointData_18(HandleRef pThis);

		public virtual int GetPassPointData()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetPassPointData_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetScalarMode_19(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarMode_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_GetScalarModeAsString_20(HandleRef pThis);

		public string GetScalarModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeAsString_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetScalarModeMaxValue_21(HandleRef pThis);

		public virtual int GetScalarModeMaxValue()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetScalarModeMinValue_22(HandleRef pThis);

		public virtual int GetScalarModeMinValue()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipClosedSurface_GetTolerance_23(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetTolerance_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_GetTriangulationErrorDisplay_24(HandleRef pThis);

		public virtual int GetTriangulationErrorDisplay()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetTriangulationErrorDisplay_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipClosedSurface_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipClosedSurface NewInstance()
		{
			vtkClipClosedSurface result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_PassPointDataOff_29(HandleRef pThis);

		public virtual void PassPointDataOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_PassPointDataOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_PassPointDataOn_30(HandleRef pThis);

		public virtual void PassPointDataOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_PassPointDataOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipClosedSurface_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipClosedSurface SafeDownCast(vtkObjectBase o)
		{
			vtkClipClosedSurface vtkClipClosedSurface = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipClosedSurface = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipClosedSurface.Register(null);
				}
			}
			return vtkClipClosedSurface;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetActivePlaneColor_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneColor_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetActivePlaneColor_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetActivePlaneColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneColor_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetActivePlaneId_34(HandleRef pThis, int _arg);

		public virtual void SetActivePlaneId(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneId_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetBaseColor_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBaseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetBaseColor_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetBaseColor_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetBaseColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetBaseColor_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetClipColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetClipColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClipColor_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetClipColor_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetClipColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClipColor_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetClippingPlanes_39(HandleRef pThis, HandleRef planes);

		public virtual void SetClippingPlanes(vtkPlaneCollection planes)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClippingPlanes_39(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetGenerateFaces_40(HandleRef pThis, int _arg);

		public virtual void SetGenerateFaces(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetGenerateFaces_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetGenerateOutline_41(HandleRef pThis, int _arg);

		public virtual void SetGenerateOutline(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetGenerateOutline_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetPassPointData_42(HandleRef pThis, int _arg);

		public virtual void SetPassPointData(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetPassPointData_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetScalarMode_43(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarMode_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetScalarModeToColors_44(HandleRef pThis);

		public void SetScalarModeToColors()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToColors_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetScalarModeToLabels_45(HandleRef pThis);

		public void SetScalarModeToLabels()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToLabels_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetScalarModeToNone_46(HandleRef pThis);

		public void SetScalarModeToNone()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToNone_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetTolerance_47(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetTolerance_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_SetTriangulationErrorDisplay_48(HandleRef pThis, int _arg);

		public virtual void SetTriangulationErrorDisplay(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetTriangulationErrorDisplay_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOff_49(HandleRef pThis);

		public virtual void TriangulationErrorDisplayOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_TriangulationErrorDisplayOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOn_50(HandleRef pThis);

		public virtual void TriangulationErrorDisplayOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_TriangulationErrorDisplayOn_50(base.GetCppThis());
		}
	}
}
