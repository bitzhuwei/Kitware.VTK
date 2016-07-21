using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCutter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCutter";

		public new static readonly string MRClassNameKey;

		static vtkCutter()
		{
			vtkCutter.MRClassNameKey = "class vtkCutter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutter"));
		}

		public vtkCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCutter New()
		{
			vtkCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutter.vtkCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCutter.vtkCutter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkCutter.vtkCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GenerateCutScalarsOff_02(HandleRef pThis);

		public virtual void GenerateCutScalarsOff()
		{
			vtkCutter.vtkCutter_GenerateCutScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GenerateCutScalarsOn_03(HandleRef pThis);

		public virtual void GenerateCutScalarsOn()
		{
			vtkCutter.vtkCutter_GenerateCutScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GenerateValues_04(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkCutter.vtkCutter_GenerateValues_04(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GenerateValues_05(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkCutter.vtkCutter_GenerateValues_05(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GetCellTypeDimensions_06(IntPtr cellTypeDimensions);

		public static void GetCellTypeDimensions(IntPtr cellTypeDimensions)
		{
			vtkCutter.vtkCutter_GetCellTypeDimensions_06(cellTypeDimensions);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_GetCutFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutter.vtkCutter_GetCutFunction_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_GetGenerateCutScalars_08(HandleRef pThis);

		public virtual int GetGenerateCutScalars()
		{
			return vtkCutter.vtkCutter_GetGenerateCutScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_GetLocator_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutter.vtkCutter_GetLocator_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkCutter_GetMTime_10(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkCutter.vtkCutter_GetMTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_GetNumberOfContours_11(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkCutter.vtkCutter_GetNumberOfContours_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_GetSortBy_12(HandleRef pThis);

		public virtual int GetSortBy()
		{
			return vtkCutter.vtkCutter_GetSortBy_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_GetSortByAsString_13(HandleRef pThis);

		public string GetSortByAsString()
		{
			return Marshal.PtrToStringAnsi(vtkCutter.vtkCutter_GetSortByAsString_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_GetSortByMaxValue_14(HandleRef pThis);

		public virtual int GetSortByMaxValue()
		{
			return vtkCutter.vtkCutter_GetSortByMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_GetSortByMinValue_15(HandleRef pThis);

		public virtual int GetSortByMinValue()
		{
			return vtkCutter.vtkCutter_GetSortByMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCutter_GetValue_16(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkCutter.vtkCutter_GetValue_16(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_GetValues_17(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkCutter.vtkCutter_GetValues_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_GetValues_18(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkCutter.vtkCutter_GetValues_18(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCutter.vtkCutter_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCutter_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCutter.vtkCutter_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCutter NewInstance()
		{
			vtkCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutter.vtkCutter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCutter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCutter SafeDownCast(vtkObjectBase o)
		{
			vtkCutter vtkCutter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutter.vtkCutter_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCutter = (vtkCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCutter.Register(null);
				}
			}
			return vtkCutter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetCutFunction_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkCutter.vtkCutter_SetCutFunction_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetGenerateCutScalars_25(HandleRef pThis, int _arg);

		public virtual void SetGenerateCutScalars(int _arg)
		{
			vtkCutter.vtkCutter_SetGenerateCutScalars_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetLocator_26(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCutter.vtkCutter_SetLocator_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetNumberOfContours_27(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkCutter.vtkCutter_SetNumberOfContours_27(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetSortBy_28(HandleRef pThis, int _arg);

		public virtual void SetSortBy(int _arg)
		{
			vtkCutter.vtkCutter_SetSortBy_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetSortByToSortByCell_29(HandleRef pThis);

		public void SetSortByToSortByCell()
		{
			vtkCutter.vtkCutter_SetSortByToSortByCell_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetSortByToSortByValue_30(HandleRef pThis);

		public void SetSortByToSortByValue()
		{
			vtkCutter.vtkCutter_SetSortByToSortByValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCutter_SetValue_31(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkCutter.vtkCutter_SetValue_31(base.GetCppThis(), i, value);
		}
	}
}
