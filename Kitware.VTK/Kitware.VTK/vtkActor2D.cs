using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkActor2D : vtkProp
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkActor2D";

		public new static readonly string MRClassNameKey;

		static vtkActor2D()
		{
			vtkActor2D.MRClassNameKey = "class vtkActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor2D"));
		}

		public vtkActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkActor2D New()
		{
			vtkActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkActor2D.vtkActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_GetActors2D_01(HandleRef pThis, HandleRef pc);

		public override void GetActors2D(vtkPropCollection pc)
		{
			vtkActor2D.vtkActor2D_GetActors2D_01(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetActualPosition2Coordinate_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetActualPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetActualPosition2Coordinate_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetActualPositionCoordinate_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetActualPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetActualPositionCoordinate_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkActor2D_GetHeight_04(HandleRef pThis);

		public double GetHeight()
		{
			return vtkActor2D.vtkActor2D_GetHeight_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_GetLayerNumber_05(HandleRef pThis);

		public virtual int GetLayerNumber()
		{
			return vtkActor2D.vtkActor2D_GetLayerNumber_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkActor2D_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkActor2D.vtkActor2D_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMapper2D GetMapper()
		{
			vtkMapper2D vtkMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetMapper_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper2D = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper2D.Register(null);
				}
			}
			return vtkMapper2D;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetPosition_08(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetPosition2_09(HandleRef pThis);

		public virtual double[] GetPosition2()
		{
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition2_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetPosition2Coordinate_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition2Coordinate_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetPositionCoordinate_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPositionCoordinate_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkActor2D_GetWidth_13(HandleRef pThis);

		public double GetWidth()
		{
			return vtkActor2D.vtkActor2D_GetWidth_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkActor2D.vtkActor2D_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkActor2D.vtkActor2D_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkActor2D.vtkActor2D_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkActor2D NewInstance()
		{
			vtkActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkActor2D.vtkActor2D_ReleaseGraphicsResources_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderOpaqueGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_RenderOverlay_21(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderOverlay_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkActor2D_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor2D_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor2D.vtkActor2D_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetDisplayPosition_24(HandleRef pThis, int arg0, int arg1);

		public void SetDisplayPosition(int arg0, int arg1)
		{
			vtkActor2D.vtkActor2D_SetDisplayPosition_24(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetHeight_25(HandleRef pThis, double h);

		public void SetHeight(double h)
		{
			vtkActor2D.vtkActor2D_SetHeight_25(base.GetCppThis(), h);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetLayerNumber_26(HandleRef pThis, int _arg);

		public virtual void SetLayerNumber(int _arg)
		{
			vtkActor2D.vtkActor2D_SetLayerNumber_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetMapper_27(HandleRef pThis, HandleRef mapper);

		public virtual void SetMapper(vtkMapper2D mapper)
		{
			vtkActor2D.vtkActor2D_SetMapper_27(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetPosition_28(HandleRef pThis, IntPtr x);

		public virtual void SetPosition(IntPtr x)
		{
			vtkActor2D.vtkActor2D_SetPosition_28(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetPosition_29(HandleRef pThis, double x, double y);

		public virtual void SetPosition(double x, double y)
		{
			vtkActor2D.vtkActor2D_SetPosition_29(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetPosition2_30(HandleRef pThis, IntPtr x);

		public virtual void SetPosition2(IntPtr x)
		{
			vtkActor2D.vtkActor2D_SetPosition2_30(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetPosition2_31(HandleRef pThis, double x, double y);

		public virtual void SetPosition2(double x, double y)
		{
			vtkActor2D.vtkActor2D_SetPosition2_31(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetProperty_32(HandleRef pThis, HandleRef arg0);

		public virtual void SetProperty(vtkProperty2D arg0)
		{
			vtkActor2D.vtkActor2D_SetProperty_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_SetWidth_33(HandleRef pThis, double w);

		public void SetWidth(double w)
		{
			vtkActor2D.vtkActor2D_SetWidth_33(base.GetCppThis(), w);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkActor2D_ShallowCopy_34(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkActor2D.vtkActor2D_ShallowCopy_34(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
