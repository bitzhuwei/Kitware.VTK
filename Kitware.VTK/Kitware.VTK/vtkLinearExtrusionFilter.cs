using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLinearExtrusionFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearExtrusionFilter";

		public new static readonly string MRClassNameKey;

		static vtkLinearExtrusionFilter()
		{
			vtkLinearExtrusionFilter.MRClassNameKey = "class vtkLinearExtrusionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearExtrusionFilter"));
		}

		public vtkLinearExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearExtrusionFilter New()
		{
			vtkLinearExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLinearExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_GetCapping_03(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetCapping_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearExtrusionFilter_GetExtrusionPoint_04(HandleRef pThis);

		public virtual double[] GetExtrusionPoint()
		{
			IntPtr intPtr = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetExtrusionPoint_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_GetExtrusionPoint_05(HandleRef pThis, IntPtr data);

		public virtual void GetExtrusionPoint(IntPtr data)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetExtrusionPoint_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_GetExtrusionType_06(HandleRef pThis);

		public virtual int GetExtrusionType()
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetExtrusionType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_GetExtrusionTypeMaxValue_07(HandleRef pThis);

		public virtual int GetExtrusionTypeMaxValue()
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetExtrusionTypeMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_GetExtrusionTypeMinValue_08(HandleRef pThis);

		public virtual int GetExtrusionTypeMinValue()
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetExtrusionTypeMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkLinearExtrusionFilter_GetScaleFactor_09(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetScaleFactor_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearExtrusionFilter_GetVector_10(HandleRef pThis);

		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetVector_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_GetVector_11(HandleRef pThis, IntPtr data);

		public virtual void GetVector(IntPtr data)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_GetVector_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearExtrusionFilter_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearExtrusionFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLinearExtrusionFilter NewInstance()
		{
			vtkLinearExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearExtrusionFilter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLinearExtrusionFilter vtkLinearExtrusionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearExtrusionFilter = (vtkLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearExtrusionFilter.Register(null);
				}
			}
			return vtkLinearExtrusionFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetCapping_17(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetCapping_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionPoint_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetExtrusionPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionPoint_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionPoint_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetExtrusionPoint(IntPtr _arg)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionPoint_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionType_20(HandleRef pThis, int _arg);

		public virtual void SetExtrusionType(int _arg)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionType_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionTypeToNormalExtrusion_21(HandleRef pThis);

		public void SetExtrusionTypeToNormalExtrusion()
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionTypeToNormalExtrusion_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionTypeToPointExtrusion_22(HandleRef pThis);

		public void SetExtrusionTypeToPointExtrusion()
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionTypeToPointExtrusion_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetExtrusionTypeToVectorExtrusion_23(HandleRef pThis);

		public void SetExtrusionTypeToVectorExtrusion()
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetExtrusionTypeToVectorExtrusion_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetScaleFactor_24(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetScaleFactor_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetVector_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetVector_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinearExtrusionFilter_SetVector_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetVector(IntPtr _arg)
		{
			vtkLinearExtrusionFilter.vtkLinearExtrusionFilter_SetVector_26(base.GetCppThis(), _arg);
		}
	}
}
