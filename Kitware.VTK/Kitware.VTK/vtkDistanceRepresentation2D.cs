using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistanceRepresentation2D : vtkDistanceRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkDistanceRepresentation2D()
		{
			vtkDistanceRepresentation2D.MRClassNameKey = "class vtkDistanceRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation2D"));
		}

		public vtkDistanceRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceRepresentation2D New()
		{
			vtkDistanceRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistanceRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetAxis_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetAxis_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetAxisProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty2D GetAxisProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetAxisProperty_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation2D_GetDistance_04(HandleRef pThis);

		public override double GetDistance()
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetDistance_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_GetPoint1DisplayPosition_05(HandleRef pThis, IntPtr pos);

		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1DisplayPosition_05(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint1WorldPosition_06(HandleRef pThis);

		public override double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1WorldPosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_GetPoint1WorldPosition_07(HandleRef pThis, IntPtr pos);

		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint1WorldPosition_07(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_GetPoint2DisplayPosition_08(HandleRef pThis, IntPtr pos);

		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2DisplayPosition_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_GetPoint2WorldPosition_09(HandleRef pThis);

		public override double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2WorldPosition_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_GetPoint2WorldPosition_10(HandleRef pThis, IntPtr pos);

		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_GetPoint2WorldPosition_10(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation2D_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation2D_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistanceRepresentation2D NewInstance()
		{
			vtkDistanceRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_ReleaseGraphicsResources_15(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation2D_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_RenderOpaqueGeometry_16(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation2D_RenderOverlay_17(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_RenderOverlay_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation2D vtkDistanceRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation2D = (vtkDistanceRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation2D.Register(null);
				}
			}
			return vtkDistanceRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_SetPoint1DisplayPosition_19(HandleRef pThis, IntPtr pos);

		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint1DisplayPosition_19(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_SetPoint1WorldPosition_20(HandleRef pThis, IntPtr pos);

		public override void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint1WorldPosition_20(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_SetPoint2DisplayPosition_21(HandleRef pThis, IntPtr pos);

		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint2DisplayPosition_21(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation2D_SetPoint2WorldPosition_22(HandleRef pThis, IntPtr pos);

		public override void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation2D.vtkDistanceRepresentation2D_SetPoint2WorldPosition_22(base.GetCppThis(), pos);
		}
	}
}
