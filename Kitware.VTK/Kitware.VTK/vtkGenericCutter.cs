using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericCutter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCutter";

		public new static readonly string MRClassNameKey;

		static vtkGenericCutter()
		{
			vtkGenericCutter.MRClassNameKey = "class vtkGenericCutter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCutter"));
		}

		public vtkGenericCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCutter New()
		{
			vtkGenericCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericCutter.vtkGenericCutter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGenericCutter.vtkGenericCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_GenerateCutScalarsOff_02(HandleRef pThis);

		public virtual void GenerateCutScalarsOff()
		{
			vtkGenericCutter.vtkGenericCutter_GenerateCutScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_GenerateCutScalarsOn_03(HandleRef pThis);

		public virtual void GenerateCutScalarsOn()
		{
			vtkGenericCutter.vtkGenericCutter_GenerateCutScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_GenerateValues_04(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGenericCutter.vtkGenericCutter_GenerateValues_04(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_GenerateValues_05(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGenericCutter.vtkGenericCutter_GenerateValues_05(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_GetCutFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_GetCutFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCutter_GetGenerateCutScalars_07(HandleRef pThis);

		public virtual int GetGenerateCutScalars()
		{
			return vtkGenericCutter.vtkGenericCutter_GetGenerateCutScalars_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_GetLocator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_GetLocator_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericCutter_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericCutter.vtkGenericCutter_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCutter_GetNumberOfContours_10(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkGenericCutter.vtkGenericCutter_GetNumberOfContours_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericCutter_GetValue_11(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkGenericCutter.vtkGenericCutter_GetValue_11(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_GetValues_12(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkGenericCutter.vtkGenericCutter_GetValues_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_GetValues_13(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkGenericCutter.vtkGenericCutter_GetValues_13(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCutter_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCutter_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericCutter.vtkGenericCutter_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericCutter NewInstance()
		{
			vtkGenericCutter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCutter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCutter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCutter vtkGenericCutter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCutter.vtkGenericCutter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCutter = (vtkGenericCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCutter.Register(null);
				}
			}
			return vtkGenericCutter;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_SetCutFunction_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkGenericCutter.vtkGenericCutter_SetCutFunction_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_SetGenerateCutScalars_20(HandleRef pThis, int _arg);

		public virtual void SetGenerateCutScalars(int _arg)
		{
			vtkGenericCutter.vtkGenericCutter_SetGenerateCutScalars_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_SetLocator_21(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericCutter.vtkGenericCutter_SetLocator_21(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_SetNumberOfContours_22(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkGenericCutter.vtkGenericCutter_SetNumberOfContours_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCutter_SetValue_23(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkGenericCutter.vtkGenericCutter_SetValue_23(base.GetCppThis(), i, value);
		}
	}
}
