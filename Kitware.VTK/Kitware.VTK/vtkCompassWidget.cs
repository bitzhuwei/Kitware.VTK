using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompassWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompassWidget";

		public new static readonly string MRClassNameKey;

		static vtkCompassWidget()
		{
			vtkCompassWidget.MRClassNameKey = "class vtkCompassWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompassWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassWidget"));
		}

		public vtkCompassWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompassWidget New()
		{
			vtkCompassWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompassWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompassWidget.vtkCompassWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkCompassWidget.vtkCompassWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassWidget_GetDistance_02(HandleRef pThis);

		public double GetDistance()
		{
			return vtkCompassWidget.vtkCompassWidget_GetDistance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassWidget_GetHeading_03(HandleRef pThis);

		public double GetHeading()
		{
			return vtkCompassWidget.vtkCompassWidget_GetHeading_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassWidget_GetTilt_04(HandleRef pThis);

		public double GetTilt()
		{
			return vtkCompassWidget.vtkCompassWidget_GetTilt_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassWidget_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompassWidget NewInstance()
		{
			vtkCompassWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompassWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCompassWidget vtkCompassWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompassWidget = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompassWidget.Register(null);
				}
			}
			return vtkCompassWidget;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassWidget_SetDistance_10(HandleRef pThis, double t);

		public void SetDistance(double t)
		{
			vtkCompassWidget.vtkCompassWidget_SetDistance_10(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassWidget_SetHeading_11(HandleRef pThis, double v);

		public void SetHeading(double v)
		{
			vtkCompassWidget.vtkCompassWidget_SetHeading_11(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkCompassRepresentation r)
		{
			vtkCompassWidget.vtkCompassWidget_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassWidget_SetTilt_13(HandleRef pThis, double t);

		public void SetTilt(double t)
		{
			vtkCompassWidget.vtkCompassWidget_SetTilt_13(base.GetCppThis(), t);
		}
	}
}
