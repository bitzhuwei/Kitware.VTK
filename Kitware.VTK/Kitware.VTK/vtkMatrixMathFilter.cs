using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatrixMathFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixMathFilter";

		public new static readonly string MRClassNameKey;

		static vtkMatrixMathFilter()
		{
			vtkMatrixMathFilter.MRClassNameKey = "class vtkMatrixMathFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixMathFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixMathFilter"));
		}

		public vtkMatrixMathFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixMathFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixMathFilter New()
		{
			vtkMatrixMathFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatrixMathFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatrixMathFilter.vtkMatrixMathFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMatrixMathFilter_GetOperation_01(HandleRef pThis);

		public virtual int GetOperation()
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_GetOperation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMatrixMathFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMatrixMathFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixMathFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatrixMathFilter NewInstance()
		{
			vtkMatrixMathFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixMathFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixMathFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixMathFilter vtkMatrixMathFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixMathFilter = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixMathFilter.Register(null);
				}
			}
			return vtkMatrixMathFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMatrixMathFilter_SetOperation_07(HandleRef pThis, int _arg);

		public virtual void SetOperation(int _arg)
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperation_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMatrixMathFilter_SetOperationToDeterminant_08(HandleRef pThis);

		public void SetOperationToDeterminant()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToDeterminant_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMatrixMathFilter_SetOperationToEigenvalue_09(HandleRef pThis);

		public void SetOperationToEigenvalue()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToEigenvalue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMatrixMathFilter_SetOperationToEigenvector_10(HandleRef pThis);

		public void SetOperationToEigenvector()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToEigenvector_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMatrixMathFilter_SetOperationToInverse_11(HandleRef pThis);

		public void SetOperationToInverse()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToInverse_11(base.GetCppThis());
		}
	}
}
