using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeCutter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeCutter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeCutter()
		{
			vtkHyperOctreeCutter.MRClassNameKey = "class vtkHyperOctreeCutter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeCutter"));
		}

		public vtkHyperOctreeCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeCutter New()
		{
			vtkHyperOctreeCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCutter.vtkHyperOctreeCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeCutter.vtkHyperOctreeCutter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_GenerateCutScalarsOff_02(HandleRef pThis);

		public virtual void GenerateCutScalarsOff()
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_GenerateCutScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_GenerateCutScalarsOn_03(HandleRef pThis);

		public virtual void GenerateCutScalarsOn()
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_GenerateCutScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_GenerateValues_04(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_GenerateValues_04(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_GenerateValues_05(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_GenerateValues_05(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_GetCutFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetCutFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkHyperOctreeCutter_GetGenerateCutScalars_07(HandleRef pThis);

		public virtual int GetGenerateCutScalars()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetGenerateCutScalars_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_GetLocator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetLocator_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkHyperOctreeCutter_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_GetNumberOfContours_10(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetNumberOfContours_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_GetSortBy_11(HandleRef pThis);

		public virtual int GetSortBy()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetSortBy_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_GetSortByAsString_12(HandleRef pThis);

		public string GetSortByAsString()
		{
			return Marshal.PtrToStringAnsi(vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetSortByAsString_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_GetSortByMaxValue_13(HandleRef pThis);

		public virtual int GetSortByMaxValue()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetSortByMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_GetSortByMinValue_14(HandleRef pThis);

		public virtual int GetSortByMinValue()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetSortByMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeCutter_GetValue_15(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetValue_15(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_GetValues_16(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetValues_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_GetValues_17(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_GetValues_17(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCutter_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeCutter.vtkHyperOctreeCutter_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeCutter NewInstance()
		{
			vtkHyperOctreeCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCutter.vtkHyperOctreeCutter_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCutter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeCutter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeCutter vtkHyperOctreeCutter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCutter.vtkHyperOctreeCutter_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeCutter = (vtkHyperOctreeCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeCutter.Register(null);
				}
			}
			return vtkHyperOctreeCutter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetCutFunction_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetCutFunction_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetGenerateCutScalars_24(HandleRef pThis, int _arg);

		public virtual void SetGenerateCutScalars(int _arg)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetGenerateCutScalars_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetLocator_25(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetLocator_25(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetNumberOfContours_26(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetNumberOfContours_26(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetSortBy_27(HandleRef pThis, int _arg);

		public virtual void SetSortBy(int _arg)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetSortBy_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetSortByToSortByCell_28(HandleRef pThis);

		public void SetSortByToSortByCell()
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetSortByToSortByCell_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetSortByToSortByValue_29(HandleRef pThis);

		public void SetSortByToSortByValue()
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetSortByToSortByValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCutter_SetValue_30(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkHyperOctreeCutter.vtkHyperOctreeCutter_SetValue_30(base.GetCppThis(), i, value);
		}
	}
}
