using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeContourFilter()
		{
			vtkHyperOctreeContourFilter.MRClassNameKey = "class vtkHyperOctreeContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeContourFilter"));
		}

		public vtkHyperOctreeContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeContourFilter New()
		{
			vtkHyperOctreeContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GenerateValues_02(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GenerateValues_03(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeContourFilter_GetLocator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetLocator_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkHyperOctreeContourFilter_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeContourFilter_GetNumberOfContours_06(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetNumberOfContours_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeContourFilter_GetValue_07(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetValue_07(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeContourFilter_GetValues_08(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetValues_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_GetValues_09(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_GetValues_09(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeContourFilter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeContourFilter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeContourFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeContourFilter NewInstance()
		{
			vtkHyperOctreeContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeContourFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeContourFilter vtkHyperOctreeContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeContourFilter = (vtkHyperOctreeContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeContourFilter.Register(null);
				}
			}
			return vtkHyperOctreeContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_SetLocator_15(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_SetLocator_15(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_SetNumberOfContours_16(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_SetNumberOfContours_16(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeContourFilter_SetValue_17(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkHyperOctreeContourFilter.vtkHyperOctreeContourFilter_SetValue_17(base.GetCppThis(), i, value);
		}
	}
}
