using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCAAnalysisFilter : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCAAnalysisFilter";

		public new static readonly string MRClassNameKey;

		static vtkPCAAnalysisFilter()
		{
			vtkPCAAnalysisFilter.MRClassNameKey = "class vtkPCAAnalysisFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCAAnalysisFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAAnalysisFilter"));
		}

		public vtkPCAAnalysisFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAAnalysisFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCAAnalysisFilter New()
		{
			vtkPCAAnalysisFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCAAnalysisFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAAnalysisFilter_GetEvals_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFloatArray GetEvals()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetEvals_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAAnalysisFilter_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPointSet GetInput(int idx)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetInput_02(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPCAAnalysisFilter_GetModesRequiredFor_03(HandleRef pThis, double proportion);

		public int GetModesRequiredFor(double proportion)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetModesRequiredFor_03(base.GetCppThis(), proportion);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPCAAnalysisFilter_GetParameterisedShape_04(HandleRef pThis, HandleRef b, HandleRef shape);

		public void GetParameterisedShape(vtkFloatArray b, vtkPointSet shape)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetParameterisedShape_04(base.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (shape == null) ? default(HandleRef) : shape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPCAAnalysisFilter_GetShapeParameters_05(HandleRef pThis, HandleRef shape, HandleRef b, int bsize);

		public void GetShapeParameters(vtkPointSet shape, vtkFloatArray b, int bsize)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetShapeParameters_05(base.GetCppThis(), (shape == null) ? default(HandleRef) : shape.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), bsize);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPCAAnalysisFilter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPCAAnalysisFilter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAAnalysisFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCAAnalysisFilter NewInstance()
		{
			vtkPCAAnalysisFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAAnalysisFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCAAnalysisFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPCAAnalysisFilter vtkPCAAnalysisFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCAAnalysisFilter = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCAAnalysisFilter.Register(null);
				}
			}
			return vtkPCAAnalysisFilter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPCAAnalysisFilter_SetInput_11(HandleRef pThis, int idx, HandleRef p);

		public new void SetInput(int idx, vtkPointSet p)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_SetInput_11(base.GetCppThis(), idx, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPCAAnalysisFilter_SetInput_12(HandleRef pThis, int idx, HandleRef input);

		public new void SetInput(int idx, vtkDataObject input)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_SetInput_12(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPCAAnalysisFilter_SetNumberOfInputs_13(HandleRef pThis, int n);

		public void SetNumberOfInputs(int n)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_SetNumberOfInputs_13(base.GetCppThis(), n);
		}
	}
}
