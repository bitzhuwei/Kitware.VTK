using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistanceRepresentation3D : vtkDistanceRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkDistanceRepresentation3D()
		{
			vtkDistanceRepresentation3D.MRClassNameKey = "class vtkDistanceRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation3D"));
		}

		public vtkDistanceRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceRepresentation3D New()
		{
			vtkDistanceRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistanceRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetBounds_02(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation3D_GetDistance_03(HandleRef pThis);

		public override double GetDistance()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetDistance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetGlyphActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor GetGlyphActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetGlyphActor_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation3D_GetGlyphScale_05(HandleRef pThis);

		public virtual double GetGlyphScale()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetGlyphScale_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFollower GetLabelActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelActor_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation3D_GetLabelPosition_07(HandleRef pThis);

		public virtual double GetLabelPosition()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelPosition_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLabelProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelScale_09(HandleRef pThis);

		public virtual IntPtr GetLabelScale()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelScale_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLineProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLineProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(HandleRef pThis);

		public virtual int GetMaximumNumberOfRulerTicks()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(HandleRef pThis);

		public virtual int GetMaximumNumberOfRulerTicksMaxValue()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(HandleRef pThis);

		public virtual int GetMaximumNumberOfRulerTicksMinValue()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_GetPoint1DisplayPosition_14(HandleRef pThis, IntPtr pos);

		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1DisplayPosition_14(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint1WorldPosition_15(HandleRef pThis);

		public override double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1WorldPosition_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_GetPoint1WorldPosition_16(HandleRef pThis, IntPtr pos);

		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1WorldPosition_16(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_GetPoint2DisplayPosition_17(HandleRef pThis, IntPtr pos);

		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2DisplayPosition_17(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint2WorldPosition_18(HandleRef pThis);

		public override double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2WorldPosition_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_GetPoint2WorldPosition_19(HandleRef pThis, IntPtr pos);

		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2WorldPosition_19(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistanceRepresentation3D NewInstance()
		{
			vtkDistanceRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_ReleaseGraphicsResources_24(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_RenderOpaqueGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation3D vtkDistanceRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation3D = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation3D.Register(null);
				}
			}
			return vtkDistanceRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetGlyphScale_28(HandleRef pThis, double scale);

		public void SetGlyphScale(double scale)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetGlyphScale_28(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetLabelPosition_29(HandleRef pThis, double labelPosition);

		public void SetLabelPosition(double labelPosition)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelPosition_29(base.GetCppThis(), labelPosition);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetLabelScale_30(HandleRef pThis, double x, double y, double z);

		public void SetLabelScale(double x, double y, double z)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelScale_30(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetLabelScale_31(HandleRef pThis, IntPtr scale);

		public virtual void SetLabelScale(IntPtr scale)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelScale_31(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_32(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfRulerTicks(int _arg)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetPoint1DisplayPosition_33(HandleRef pThis, IntPtr pos);

		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint1DisplayPosition_33(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetPoint1WorldPosition_34(HandleRef pThis, IntPtr pos);

		public override void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint1WorldPosition_34(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetPoint2DisplayPosition_35(HandleRef pThis, IntPtr pos);

		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint2DisplayPosition_35(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation3D_SetPoint2WorldPosition_36(HandleRef pThis, IntPtr pos);

		public override void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint2WorldPosition_36(base.GetCppThis(), pos);
		}
	}
}
