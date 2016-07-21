using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkViewport : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewport";

		public new static readonly string MRClassNameKey;

		static vtkViewport()
		{
			vtkViewport.MRClassNameKey = "class vtkViewport";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewport"));
		}

		public vtkViewport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_AddActor2D_01(HandleRef pThis, HandleRef p);

		public void AddActor2D(vtkProp p)
		{
			vtkViewport.vtkViewport_AddActor2D_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_AddViewProp_02(HandleRef pThis, HandleRef arg0);

		public void AddViewProp(vtkProp arg0)
		{
			vtkViewport.vtkViewport_AddViewProp_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ComputeAspect_03(HandleRef pThis);

		public virtual void ComputeAspect()
		{
			vtkViewport.vtkViewport_ComputeAspect_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_DisplayToLocalDisplay_04(HandleRef pThis, ref double x, ref double y);

		public virtual void DisplayToLocalDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_DisplayToLocalDisplay_04(base.GetCppThis(), ref x, ref y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_DisplayToNormalizedDisplay_05(HandleRef pThis, ref double u, ref double v);

		public virtual void DisplayToNormalizedDisplay(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_DisplayToNormalizedDisplay_05(base.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_DisplayToView_06(HandleRef pThis);

		public virtual void DisplayToView()
		{
			vtkViewport.vtkViewport_DisplayToView_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_DisplayToWorld_07(HandleRef pThis);

		public void DisplayToWorld()
		{
			vtkViewport.vtkViewport_DisplayToWorld_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetActors2D_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkActor2DCollection GetActors2D()
		{
			vtkActor2DCollection vtkActor2DCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_GetActors2D_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2DCollection = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2DCollection.Register(null);
				}
			}
			return vtkActor2DCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetAspect_09(HandleRef pThis);

		public virtual double[] GetAspect()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetAspect_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetAspect_10(HandleRef pThis, IntPtr data);

		public virtual void GetAspect(IntPtr data)
		{
			vtkViewport.vtkViewport_GetAspect_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetBackground_11(HandleRef pThis);

		public virtual double[] GetBackground()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetBackground_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetBackground_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackground(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetBackground_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetBackground_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackground(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetBackground_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetBackground2_14(HandleRef pThis);

		public virtual double[] GetBackground2()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetBackground2_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetBackground2_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackground2(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetBackground2_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetBackground2_16(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackground2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetBackground2_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetCenter_17(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetCenter_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetDisplayPoint_18(HandleRef pThis);

		public virtual double[] GetDisplayPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetDisplayPoint_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetDisplayPoint_19(HandleRef pThis, IntPtr data);

		public virtual void GetDisplayPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetDisplayPoint_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkViewport_GetGradientBackground_20(HandleRef pThis);

		public virtual bool GetGradientBackground()
		{
			return vtkViewport.vtkViewport_GetGradientBackground_20(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewport_GetIsPicking_21(HandleRef pThis);

		public virtual int GetIsPicking()
		{
			return vtkViewport.vtkViewport_GetIsPicking_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetOrigin_22(HandleRef pThis);

		public virtual int[] GetOrigin()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetOrigin_22(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickHeight_23(HandleRef pThis);

		public double GetPickHeight()
		{
			return vtkViewport.vtkViewport_GetPickHeight_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetPickResultProps_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPropCollection GetPickResultProps()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_GetPickResultProps_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickWidth_25(HandleRef pThis);

		public double GetPickWidth()
		{
			return vtkViewport.vtkViewport_GetPickWidth_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickX_26(HandleRef pThis);

		public double GetPickX()
		{
			return vtkViewport.vtkViewport_GetPickX_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickX1_27(HandleRef pThis);

		public double GetPickX1()
		{
			return vtkViewport.vtkViewport_GetPickX1_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickX2_28(HandleRef pThis);

		public double GetPickX2()
		{
			return vtkViewport.vtkViewport_GetPickX2_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickY_29(HandleRef pThis);

		public double GetPickY()
		{
			return vtkViewport.vtkViewport_GetPickY_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickY1_30(HandleRef pThis);

		public double GetPickY1()
		{
			return vtkViewport.vtkViewport_GetPickY1_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickY2_31(HandleRef pThis);

		public double GetPickY2()
		{
			return vtkViewport.vtkViewport_GetPickY2_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewport_GetPickedZ_32(HandleRef pThis);

		public virtual double GetPickedZ()
		{
			return vtkViewport.vtkViewport_GetPickedZ_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetPixelAspect_33(HandleRef pThis);

		public virtual double[] GetPixelAspect()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetPixelAspect_33(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetPixelAspect_34(HandleRef pThis, IntPtr data);

		public virtual void GetPixelAspect(IntPtr data)
		{
			vtkViewport.vtkViewport_GetPixelAspect_34(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetSize_35(HandleRef pThis);

		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetSize_35(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetTiledSize_36(HandleRef pThis, IntPtr width, IntPtr height);

		public void GetTiledSize(IntPtr width, IntPtr height)
		{
			vtkViewport.vtkViewport_GetTiledSize_36(base.GetCppThis(), width, height);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetTiledSizeAndOrigin_37(HandleRef pThis, IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY);

		public virtual void GetTiledSizeAndOrigin(IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY)
		{
			vtkViewport.vtkViewport_GetTiledSizeAndOrigin_37(base.GetCppThis(), width, height, lowerLeftX, lowerLeftY);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetVTKWindow_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkWindow GetVTKWindow()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_GetVTKWindow_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetViewPoint_39(HandleRef pThis);

		public virtual double[] GetViewPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewPoint_39(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetViewPoint_40(HandleRef pThis, IntPtr data);

		public virtual void GetViewPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetViewPoint_40(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetViewProps_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPropCollection GetViewProps()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewProps_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetViewport_42(HandleRef pThis);

		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewport_42(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetViewport_43(HandleRef pThis, IntPtr data);

		public virtual void GetViewport(IntPtr data)
		{
			vtkViewport.vtkViewport_GetViewport_43(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_GetWorldPoint_44(HandleRef pThis);

		public virtual double[] GetWorldPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetWorldPoint_44(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GetWorldPoint_45(HandleRef pThis, IntPtr data);

		public virtual void GetWorldPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetWorldPoint_45(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GradientBackgroundOff_46(HandleRef pThis);

		public virtual void GradientBackgroundOff()
		{
			vtkViewport.vtkViewport_GradientBackgroundOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_GradientBackgroundOn_47(HandleRef pThis);

		public virtual void GradientBackgroundOn()
		{
			vtkViewport.vtkViewport_GradientBackgroundOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewport_HasViewProp_48(HandleRef pThis, HandleRef arg0);

		public int HasViewProp(vtkProp arg0)
		{
			return vtkViewport.vtkViewport_HasViewProp_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewport_IsA_49(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkViewport.vtkViewport_IsA_49(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewport_IsInViewport_50(HandleRef pThis, int x, int y);

		public virtual int IsInViewport(int x, int y)
		{
			return vtkViewport.vtkViewport_IsInViewport_50(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewport_IsTypeOf_51(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkViewport.vtkViewport_IsTypeOf_51(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_LocalDisplayToDisplay_52(HandleRef pThis, ref double x, ref double y);

		public virtual void LocalDisplayToDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_LocalDisplayToDisplay_52(base.GetCppThis(), ref x, ref y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkViewport NewInstance()
		{
			vtkViewport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_NewInstance_53(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_NormalizedDisplayToDisplay_54(HandleRef pThis, ref double u, ref double v);

		public virtual void NormalizedDisplayToDisplay(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_NormalizedDisplayToDisplay_54(base.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_NormalizedDisplayToViewport_55(HandleRef pThis, ref double x, ref double y);

		public virtual void NormalizedDisplayToViewport(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_NormalizedDisplayToViewport_55(base.GetCppThis(), ref x, ref y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_NormalizedViewportToView_56(HandleRef pThis, ref double x, ref double y, ref double z);

		public virtual void NormalizedViewportToView(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_NormalizedViewportToView_56(base.GetCppThis(), ref x, ref y, ref z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_NormalizedViewportToViewport_57(HandleRef pThis, ref double u, ref double v);

		public virtual void NormalizedViewportToViewport(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_NormalizedViewportToViewport_57(base.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_PickProp_58(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAssemblyPath PickProp(double selectionX, double selectionY)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_PickProp_58(base.GetCppThis(), selectionX, selectionY, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_PickPropFrom_59(HandleRef pThis, double selectionX, double selectionY, HandleRef arg2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyPath PickPropFrom(double selectionX, double selectionY, vtkPropCollection arg2)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_PickPropFrom_59(base.GetCppThis(), selectionX, selectionY, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_RemoveActor2D_60(HandleRef pThis, HandleRef p);

		public void RemoveActor2D(vtkProp p)
		{
			vtkViewport.vtkViewport_RemoveActor2D_60(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_RemoveAllViewProps_61(HandleRef pThis);

		public void RemoveAllViewProps()
		{
			vtkViewport.vtkViewport_RemoveAllViewProps_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_RemoveViewProp_62(HandleRef pThis, HandleRef arg0);

		public void RemoveViewProp(vtkProp arg0)
		{
			vtkViewport.vtkViewport_RemoveViewProp_62(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewport_SafeDownCast_63(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewport SafeDownCast(vtkObjectBase o)
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewport.vtkViewport_SafeDownCast_63((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetAspect_64(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetAspect(double _arg1, double _arg2)
		{
			vtkViewport.vtkViewport_SetAspect_64(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetAspect_65(HandleRef pThis, IntPtr _arg);

		public void SetAspect(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetAspect_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetBackground_66(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackground(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetBackground_66(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetBackground_67(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackground(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetBackground_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetBackground2_68(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackground2(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetBackground2_68(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetBackground2_69(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackground2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetBackground2_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetDisplayPoint_70(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDisplayPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetDisplayPoint_70(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetDisplayPoint_71(HandleRef pThis, IntPtr _arg);

		public virtual void SetDisplayPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetDisplayPoint_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetGradientBackground_72(HandleRef pThis, byte _arg);

		public virtual void SetGradientBackground(bool _arg)
		{
			vtkViewport.vtkViewport_SetGradientBackground_72(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetPixelAspect_73(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetPixelAspect(double _arg1, double _arg2)
		{
			vtkViewport.vtkViewport_SetPixelAspect_73(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetPixelAspect_74(HandleRef pThis, IntPtr _arg);

		public void SetPixelAspect(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetPixelAspect_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetViewPoint_75(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetViewPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetViewPoint_75(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetViewPoint_76(HandleRef pThis, IntPtr _arg);

		public virtual void SetViewPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetViewPoint_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetViewport_77(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkViewport.vtkViewport_SetViewport_77(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetViewport_78(HandleRef pThis, IntPtr _arg);

		public virtual void SetViewport(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetViewport_78(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetWorldPoint_79(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetWorldPoint(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkViewport.vtkViewport_SetWorldPoint_79(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_SetWorldPoint_80(HandleRef pThis, IntPtr _arg);

		public virtual void SetWorldPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetWorldPoint_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewToDisplay_81(HandleRef pThis);

		public virtual void ViewToDisplay()
		{
			vtkViewport.vtkViewport_ViewToDisplay_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewToNormalizedViewport_82(HandleRef pThis, ref double x, ref double y, ref double z);

		public virtual void ViewToNormalizedViewport(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_ViewToNormalizedViewport_82(base.GetCppThis(), ref x, ref y, ref z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewToWorld_83(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		public virtual void ViewToWorld(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_ViewToWorld_83(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewToWorld_84(HandleRef pThis);

		public virtual void ViewToWorld()
		{
			vtkViewport.vtkViewport_ViewToWorld_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewportToNormalizedDisplay_85(HandleRef pThis, ref double x, ref double y);

		public virtual void ViewportToNormalizedDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_ViewportToNormalizedDisplay_85(base.GetCppThis(), ref x, ref y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_ViewportToNormalizedViewport_86(HandleRef pThis, ref double u, ref double v);

		public virtual void ViewportToNormalizedViewport(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_ViewportToNormalizedViewport_86(base.GetCppThis(), ref u, ref v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_WorldToDisplay_87(HandleRef pThis);

		public void WorldToDisplay()
		{
			vtkViewport.vtkViewport_WorldToDisplay_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_WorldToView_88(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		public virtual void WorldToView(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_WorldToView_88(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewport_WorldToView_89(HandleRef pThis);

		public virtual void WorldToView()
		{
			vtkViewport.vtkViewport_WorldToView_89(base.GetCppThis());
		}
	}
}
