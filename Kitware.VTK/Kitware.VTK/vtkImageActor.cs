using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageActor : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageActor";

		public new static readonly string MRClassNameKey;

		static vtkImageActor()
		{
			vtkImageActor.MRClassNameKey = "class vtkImageActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageActor"));
		}

		public vtkImageActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageActor New()
		{
			vtkImageActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageActor.vtkImageActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageActor.vtkImageActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_GetBounds_01(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkImageActor.vtkImageActor_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_GetDisplayBounds_03(HandleRef pThis);

		public IntPtr GetDisplayBounds()
		{
			return vtkImageActor.vtkImageActor_GetDisplayBounds_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_GetDisplayBounds_04(HandleRef pThis, IntPtr bounds);

		public void GetDisplayBounds(IntPtr bounds)
		{
			vtkImageActor.vtkImageActor_GetDisplayBounds_04(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_GetDisplayExtent_05(HandleRef pThis, IntPtr extent);

		public void GetDisplayExtent(IntPtr extent)
		{
			vtkImageActor.vtkImageActor_GetDisplayExtent_05(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_GetDisplayExtent_06(HandleRef pThis);

		public int[] GetDisplayExtent()
		{
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetDisplayExtent_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetInterpolate_08(HandleRef pThis);

		public virtual int GetInterpolate()
		{
			return vtkImageActor.vtkImageActor_GetInterpolate_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageActor_GetOpacity_09(HandleRef pThis);

		public virtual double GetOpacity()
		{
			return vtkImageActor.vtkImageActor_GetOpacity_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageActor_GetOpacityMaxValue_10(HandleRef pThis);

		public virtual double GetOpacityMaxValue()
		{
			return vtkImageActor.vtkImageActor_GetOpacityMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageActor_GetOpacityMinValue_11(HandleRef pThis);

		public virtual double GetOpacityMinValue()
		{
			return vtkImageActor.vtkImageActor_GetOpacityMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetSliceNumber_12(HandleRef pThis);

		public int GetSliceNumber()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumber_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetSliceNumberMax_13(HandleRef pThis);

		public int GetSliceNumberMax()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumberMax_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetSliceNumberMin_14(HandleRef pThis);

		public int GetSliceNumberMin()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumberMin_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetWholeZMax_15(HandleRef pThis);

		public int GetWholeZMax()
		{
			return vtkImageActor.vtkImageActor_GetWholeZMax_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetWholeZMin_16(HandleRef pThis);

		public int GetWholeZMin()
		{
			return vtkImageActor.vtkImageActor_GetWholeZMin_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_GetZSlice_17(HandleRef pThis);

		public int GetZSlice()
		{
			return vtkImageActor.vtkImageActor_GetZSlice_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImageActor.vtkImageActor_HasTranslucentPolygonalGeometry_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_InterpolateOff_19(HandleRef pThis);

		public virtual void InterpolateOff()
		{
			vtkImageActor.vtkImageActor_InterpolateOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_InterpolateOn_20(HandleRef pThis);

		public virtual void InterpolateOn()
		{
			vtkImageActor.vtkImageActor_InterpolateOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageActor.vtkImageActor_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageActor.vtkImageActor_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageActor NewInstance()
		{
			vtkImageActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageActor.vtkImageActor_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_Render_25(HandleRef pThis, HandleRef arg0);

		public virtual void Render(vtkRenderer arg0)
		{
			vtkImageActor.vtkImageActor_Render_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkImageActor.vtkImageActor_RenderOpaqueGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageActor_RenderTranslucentPolygonalGeometry_27(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkImageActor.vtkImageActor_RenderTranslucentPolygonalGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageActor_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageActor SafeDownCast(vtkObjectBase o)
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageActor.vtkImageActor_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetDisplayExtent_29(HandleRef pThis, IntPtr extent);

		public void SetDisplayExtent(IntPtr extent)
		{
			vtkImageActor.vtkImageActor_SetDisplayExtent_29(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetDisplayExtent_30(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetDisplayExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageActor.vtkImageActor_SetDisplayExtent_30(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetInput_31(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkImageData arg0)
		{
			vtkImageActor.vtkImageActor_SetInput_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetInterpolate_32(HandleRef pThis, int _arg);

		public virtual void SetInterpolate(int _arg)
		{
			vtkImageActor.vtkImageActor_SetInterpolate_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetOpacity_33(HandleRef pThis, double _arg);

		public virtual void SetOpacity(double _arg)
		{
			vtkImageActor.vtkImageActor_SetOpacity_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageActor_SetZSlice_34(HandleRef pThis, int z);

		public void SetZSlice(int z)
		{
			vtkImageActor.vtkImageActor_SetZSlice_34(base.GetCppThis(), z);
		}
	}
}
