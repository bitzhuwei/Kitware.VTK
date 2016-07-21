using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAngleRepresentation3D : vtkAngleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkAngleRepresentation3D()
		{
			vtkAngleRepresentation3D.MRClassNameKey = "class vtkAngleRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation3D"));
		}

		public vtkAngleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleRepresentation3D New()
		{
			vtkAngleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAngleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAngleRepresentation3D.vtkAngleRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkAngleRepresentation3D_GetAngle_02(HandleRef pThis);

		public override double GetAngle()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetAngle_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation3D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor GetArc()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetArc_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAngleRepresentation3D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

		public override void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetCenterDisplayPosition_04(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

		public override void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetCenterWorldPosition_05(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_GetPoint1DisplayPosition_06(HandleRef pThis, IntPtr pos);

		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint1DisplayPosition_06(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_GetPoint1WorldPosition_07(HandleRef pThis, IntPtr pos);

		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint1WorldPosition_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_GetPoint2DisplayPosition_08(HandleRef pThis, IntPtr pos);

		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint2DisplayPosition_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_GetPoint2WorldPosition_09(HandleRef pThis, IntPtr pos);

		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint2WorldPosition_09(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation3D_GetRay1_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor GetRay1()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetRay1_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAngleRepresentation3D_GetRay2_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor GetRay2()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetRay2_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAngleRepresentation3D_GetTextActor_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFollower GetTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetTextActor_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAngleRepresentation3D_GetTextActorScale_13(HandleRef pThis);

		public virtual IntPtr GetTextActorScale()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetTextActorScale_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation3D_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation3D_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation3D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAngleRepresentation3D NewInstance()
		{
			vtkAngleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_ReleaseGraphicsResources_19(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation3D_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_RenderOpaqueGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_21(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation3D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation3D vtkAngleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation3D = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation3D.Register(null);
				}
			}
			return vtkAngleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetCenterDisplayPosition_23(HandleRef pThis, IntPtr pos);

		public override void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetCenterDisplayPosition_23(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetCenterWorldPosition_24(HandleRef pThis, IntPtr pos);

		public virtual void SetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetCenterWorldPosition_24(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetPoint1DisplayPosition_25(HandleRef pThis, IntPtr pos);

		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint1DisplayPosition_25(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetPoint1WorldPosition_26(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint1WorldPosition_26(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetPoint2DisplayPosition_27(HandleRef pThis, IntPtr pos);

		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint2DisplayPosition_27(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetPoint2WorldPosition_28(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint2WorldPosition_28(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation3D_SetTextActorScale_29(HandleRef pThis, IntPtr scale);

		public virtual void SetTextActorScale(IntPtr scale)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetTextActorScale_29(base.GetCppThis(), scale);
		}
	}
}
