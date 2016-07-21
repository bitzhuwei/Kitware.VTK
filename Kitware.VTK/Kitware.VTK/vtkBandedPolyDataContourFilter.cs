using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBandedPolyDataContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBandedPolyDataContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkBandedPolyDataContourFilter()
		{
			vtkBandedPolyDataContourFilter.MRClassNameKey = "class vtkBandedPolyDataContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBandedPolyDataContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBandedPolyDataContourFilter"));
		}

		public vtkBandedPolyDataContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBandedPolyDataContourFilter New()
		{
			vtkBandedPolyDataContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBandedPolyDataContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_ClippingOff_01(HandleRef pThis);

		public virtual void ClippingOff()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_ClippingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_ClippingOn_02(HandleRef pThis);

		public virtual void ClippingOn()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_ClippingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(HandleRef pThis);

		public virtual void GenerateContourEdgesOff()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(HandleRef pThis);

		public virtual void GenerateContourEdgesOn()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_05(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateValues_05(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_06(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateValues_06(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetClipping_07(HandleRef pThis);

		public virtual int GetClipping()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetClipping_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_GetContourEdgesOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetContourEdgesOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetContourEdgesOutput_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetGenerateContourEdges_09(HandleRef pThis);

		public virtual int GetGenerateContourEdges()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetGenerateContourEdges_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkBandedPolyDataContourFilter_GetMTime_10(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetMTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetNumberOfContours_11(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetNumberOfContours_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarMode_12(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_13(HandleRef pThis);

		public virtual int GetScalarModeMaxValue()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMinValue_14(HandleRef pThis);

		public virtual int GetScalarModeMinValue()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarModeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBandedPolyDataContourFilter_GetValue_15(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValue_15(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_GetValues_16(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValues_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_GetValues_17(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValues_17(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBandedPolyDataContourFilter_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBandedPolyDataContourFilter NewInstance()
		{
			vtkBandedPolyDataContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBandedPolyDataContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkBandedPolyDataContourFilter vtkBandedPolyDataContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBandedPolyDataContourFilter = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBandedPolyDataContourFilter.Register(null);
				}
			}
			return vtkBandedPolyDataContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetClipping_23(HandleRef pThis, int _arg);

		public virtual void SetClipping(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetClipping_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetGenerateContourEdges_24(HandleRef pThis, int _arg);

		public virtual void SetGenerateContourEdges(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetGenerateContourEdges_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetNumberOfContours_25(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetNumberOfContours_25(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarMode_26(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToIndex_27(HandleRef pThis);

		public void SetScalarModeToIndex()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarModeToIndex_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToValue_28(HandleRef pThis);

		public void SetScalarModeToValue()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarModeToValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBandedPolyDataContourFilter_SetValue_29(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetValue_29(base.GetCppThis(), i, value);
		}
	}
}
