using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAngleRepresentation2D : vtkAngleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkAngleRepresentation2D()
		{
			vtkAngleRepresentation2D.MRClassNameKey = "class vtkAngleRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation2D"));
		}

		public vtkAngleRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleRepresentation2D New()
		{
			vtkAngleRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAngleRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAngleRepresentation2D.vtkAngleRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkAngleRepresentation2D_GetAngle_02(HandleRef pThis);

		public override double GetAngle()
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetAngle_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLeaderActor2D GetArc()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetArc_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

		public override void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetCenterDisplayPosition_04(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

		public override void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetCenterWorldPosition_05(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetPoint1DisplayPosition_06(HandleRef pThis, IntPtr pos);

		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint1DisplayPosition_06(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetPoint1WorldPosition_07(HandleRef pThis, IntPtr pos);

		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint1WorldPosition_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetPoint2DisplayPosition_08(HandleRef pThis, IntPtr pos);

		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint2DisplayPosition_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_GetPoint2WorldPosition_09(HandleRef pThis, IntPtr pos);

		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint2WorldPosition_09(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_GetRay1_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLeaderActor2D GetRay1()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetRay1_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_GetRay2_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLeaderActor2D GetRay2()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetRay2_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation2D_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation2D_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAngleRepresentation2D NewInstance()
		{
			vtkAngleRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_ReleaseGraphicsResources_16(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation2D_RenderOverlay_17(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_RenderOverlay_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation2D vtkAngleRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation2D = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation2D.Register(null);
				}
			}
			return vtkAngleRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_SetCenterDisplayPosition_19(HandleRef pThis, IntPtr pos);

		public override void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetCenterDisplayPosition_19(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_SetPoint1DisplayPosition_20(HandleRef pThis, IntPtr pos);

		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint1DisplayPosition_20(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation2D_SetPoint2DisplayPosition_21(HandleRef pThis, IntPtr pos);

		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint2DisplayPosition_21(base.GetCppThis(), pos);
		}
	}
}
