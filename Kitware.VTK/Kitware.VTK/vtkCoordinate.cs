using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCoordinate : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinate";

		public new static readonly string MRClassNameKey;

		static vtkCoordinate()
		{
			vtkCoordinate.MRClassNameKey = "class vtkCoordinate";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoordinate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinate"));
		}

		public vtkCoordinate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCoordinate New()
		{
			vtkCoordinate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCoordinate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCoordinate.vtkCoordinate_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedDisplayValue_01(HandleRef pThis, HandleRef arg0);

		public int[] GetComputedDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDisplayValue_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedDoubleDisplayValue_02(HandleRef pThis, HandleRef arg0);

		public double[] GetComputedDoubleDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDoubleDisplayValue_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedDoubleViewportValue_03(HandleRef pThis, HandleRef arg0);

		public double[] GetComputedDoubleViewportValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedDoubleViewportValue_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedLocalDisplayValue_04(HandleRef pThis, HandleRef arg0);

		public int[] GetComputedLocalDisplayValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedLocalDisplayValue_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedUserDefinedValue_05(HandleRef pThis, HandleRef arg0);

		public virtual IntPtr GetComputedUserDefinedValue(vtkViewport arg0)
		{
			return vtkCoordinate.vtkCoordinate_GetComputedUserDefinedValue_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedValue_06(HandleRef pThis, HandleRef arg0);

		public IntPtr GetComputedValue(vtkViewport arg0)
		{
			return vtkCoordinate.vtkCoordinate_GetComputedValue_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedViewportValue_07(HandleRef pThis, HandleRef arg0);

		public int[] GetComputedViewportValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedViewportValue_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetComputedWorldValue_08(HandleRef pThis, HandleRef arg0);

		public double[] GetComputedWorldValue(vtkViewport arg0)
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetComputedWorldValue_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCoordinate_GetCoordinateSystem_09(HandleRef pThis);

		public virtual int GetCoordinateSystem()
		{
			return vtkCoordinate.vtkCoordinate_GetCoordinateSystem_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetCoordinateSystemAsString_10(HandleRef pThis);

		public string GetCoordinateSystemAsString()
		{
			return Marshal.PtrToStringAnsi(vtkCoordinate.vtkCoordinate_GetCoordinateSystemAsString_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetReferenceCoordinate_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetReferenceCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetReferenceCoordinate_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCoordinate_GetValue_12(HandleRef pThis);

		public virtual double[] GetValue()
		{
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetValue_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_GetValue_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetValue(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinate.vtkCoordinate_GetValue_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_GetValue_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetValue(IntPtr _arg)
		{
			vtkCoordinate.vtkCoordinate_GetValue_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_GetViewport_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_GetViewport_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkCoordinate_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCoordinate.vtkCoordinate_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCoordinate_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCoordinate.vtkCoordinate_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCoordinate NewInstance()
		{
			vtkCoordinate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCoordinate_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCoordinate SafeDownCast(vtkObjectBase o)
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoordinate.vtkCoordinate_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkCoordinate_SetCoordinateSystem_21(HandleRef pThis, int _arg);

		public virtual void SetCoordinateSystem(int _arg)
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystem_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToDisplay_22(HandleRef pThis);

		public void SetCoordinateSystemToDisplay()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToDisplay_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_23(HandleRef pThis);

		public void SetCoordinateSystemToNormalizedDisplay()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedViewport_24(HandleRef pThis);

		public void SetCoordinateSystemToNormalizedViewport()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToNormalizedViewport_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToView_25(HandleRef pThis);

		public void SetCoordinateSystemToView()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToView_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToViewport_26(HandleRef pThis);

		public void SetCoordinateSystemToViewport()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToViewport_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetCoordinateSystemToWorld_27(HandleRef pThis);

		public void SetCoordinateSystemToWorld()
		{
			vtkCoordinate.vtkCoordinate_SetCoordinateSystemToWorld_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetReferenceCoordinate_28(HandleRef pThis, HandleRef arg0);

		public virtual void SetReferenceCoordinate(vtkCoordinate arg0)
		{
			vtkCoordinate.vtkCoordinate_SetReferenceCoordinate_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetValue_29(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetValue(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinate.vtkCoordinate_SetValue_29(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetValue_30(HandleRef pThis, IntPtr _arg);

		public virtual void SetValue(IntPtr _arg)
		{
			vtkCoordinate.vtkCoordinate_SetValue_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetValue_31(HandleRef pThis, double a, double b);

		public void SetValue(double a, double b)
		{
			vtkCoordinate.vtkCoordinate_SetValue_31(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCoordinate_SetViewport_32(HandleRef pThis, HandleRef viewport);

		public void SetViewport(vtkViewport viewport)
		{
			vtkCoordinate.vtkCoordinate_SetViewport_32(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}
	}
}
