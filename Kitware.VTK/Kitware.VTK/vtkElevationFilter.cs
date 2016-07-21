using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkElevationFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkElevationFilter";

		public new static readonly string MRClassNameKey;

		static vtkElevationFilter()
		{
			vtkElevationFilter.MRClassNameKey = "class vtkElevationFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkElevationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkElevationFilter"));
		}

		public vtkElevationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkElevationFilter New()
		{
			vtkElevationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkElevationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkElevationFilter.vtkElevationFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_GetHighPoint_01(HandleRef pThis);

		public virtual double[] GetHighPoint()
		{
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_GetHighPoint_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_GetHighPoint_02(HandleRef pThis, IntPtr data);

		public virtual void GetHighPoint(IntPtr data)
		{
			vtkElevationFilter.vtkElevationFilter_GetHighPoint_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_GetLowPoint_03(HandleRef pThis);

		public virtual double[] GetLowPoint()
		{
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_GetLowPoint_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_GetLowPoint_04(HandleRef pThis, IntPtr data);

		public virtual void GetLowPoint(IntPtr data)
		{
			vtkElevationFilter.vtkElevationFilter_GetLowPoint_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_GetScalarRange_05(HandleRef pThis);

		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_GetScalarRange_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_GetScalarRange_06(HandleRef pThis, IntPtr data);

		public virtual void GetScalarRange(IntPtr data)
		{
			vtkElevationFilter.vtkElevationFilter_GetScalarRange_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkElevationFilter_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkElevationFilter.vtkElevationFilter_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkElevationFilter_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkElevationFilter.vtkElevationFilter_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkElevationFilter NewInstance()
		{
			vtkElevationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkElevationFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkElevationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkElevationFilter vtkElevationFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkElevationFilter.vtkElevationFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkElevationFilter = (vtkElevationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkElevationFilter.Register(null);
				}
			}
			return vtkElevationFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetHighPoint_12(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetHighPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkElevationFilter.vtkElevationFilter_SetHighPoint_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetHighPoint_13(HandleRef pThis, IntPtr _arg);

		public virtual void SetHighPoint(IntPtr _arg)
		{
			vtkElevationFilter.vtkElevationFilter_SetHighPoint_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetLowPoint_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetLowPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkElevationFilter.vtkElevationFilter_SetLowPoint_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetLowPoint_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetLowPoint(IntPtr _arg)
		{
			vtkElevationFilter.vtkElevationFilter_SetLowPoint_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetScalarRange_16(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkElevationFilter.vtkElevationFilter_SetScalarRange_16(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkElevationFilter_SetScalarRange_17(HandleRef pThis, IntPtr _arg);

		public void SetScalarRange(IntPtr _arg)
		{
			vtkElevationFilter.vtkElevationFilter_SetScalarRange_17(base.GetCppThis(), _arg);
		}
	}
}
