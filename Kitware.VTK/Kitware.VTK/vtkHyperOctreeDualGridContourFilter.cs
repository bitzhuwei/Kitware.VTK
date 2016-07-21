using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeDualGridContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeDualGridContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeDualGridContourFilter()
		{
			vtkHyperOctreeDualGridContourFilter.MRClassNameKey = "class vtkHyperOctreeDualGridContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeDualGridContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeDualGridContourFilter"));
		}

		public vtkHyperOctreeDualGridContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeDualGridContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeDualGridContourFilter New()
		{
			vtkHyperOctreeDualGridContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeDualGridContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeDualGridContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GenerateValues_02(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GenerateValues_03(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeDualGridContourFilter_GetLocator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetLocator_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkHyperOctreeDualGridContourFilter_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeDualGridContourFilter_GetNumberOfContours_06(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetNumberOfContours_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeDualGridContourFilter_GetValue_07(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetValue_07(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeDualGridContourFilter_GetValues_08(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetValues_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_GetValues_09(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_GetValues_09(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeDualGridContourFilter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeDualGridContourFilter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeDualGridContourFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeDualGridContourFilter NewInstance()
		{
			vtkHyperOctreeDualGridContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeDualGridContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeDualGridContourFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeDualGridContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeDualGridContourFilter vtkHyperOctreeDualGridContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeDualGridContourFilter = (vtkHyperOctreeDualGridContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeDualGridContourFilter.Register(null);
				}
			}
			return vtkHyperOctreeDualGridContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_SetLocator_15(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_SetLocator_15(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_SetNumberOfContours_16(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_SetNumberOfContours_16(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeDualGridContourFilter_SetValue_17(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkHyperOctreeDualGridContourFilter.vtkHyperOctreeDualGridContourFilter_SetValue_17(base.GetCppThis(), i, value);
		}
	}
}
