using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRotationalExtrusionFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRotationalExtrusionFilter";

		public new static readonly string MRClassNameKey;

		static vtkRotationalExtrusionFilter()
		{
			vtkRotationalExtrusionFilter.MRClassNameKey = "class vtkRotationalExtrusionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRotationalExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRotationalExtrusionFilter"));
		}

		public vtkRotationalExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationalExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRotationalExtrusionFilter New()
		{
			vtkRotationalExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRotationalExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRotationalExtrusionFilter_GetAngle_03(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetAngle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_GetCapping_04(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetCapping_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRotationalExtrusionFilter_GetDeltaRadius_05(HandleRef pThis);

		public virtual double GetDeltaRadius()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetDeltaRadius_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_GetResolution_06(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolution_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_GetResolutionMaxValue_07(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolutionMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_GetResolutionMinValue_08(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetResolutionMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRotationalExtrusionFilter_GetTranslation_09(HandleRef pThis);

		public virtual double GetTranslation()
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_GetTranslation_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRotationalExtrusionFilter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationalExtrusionFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRotationalExtrusionFilter NewInstance()
		{
			vtkRotationalExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRotationalExtrusionFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRotationalExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRotationalExtrusionFilter vtkRotationalExtrusionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRotationalExtrusionFilter = (vtkRotationalExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRotationalExtrusionFilter.Register(null);
				}
			}
			return vtkRotationalExtrusionFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_SetAngle_15(HandleRef pThis, double _arg);

		public virtual void SetAngle(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetAngle_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_SetCapping_16(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetCapping_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_SetDeltaRadius_17(HandleRef pThis, double _arg);

		public virtual void SetDeltaRadius(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetDeltaRadius_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_SetResolution_18(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetResolution_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRotationalExtrusionFilter_SetTranslation_19(HandleRef pThis, double _arg);

		public virtual void SetTranslation(double _arg)
		{
			vtkRotationalExtrusionFilter.vtkRotationalExtrusionFilter_SetTranslation_19(base.GetCppThis(), _arg);
		}
	}
}
