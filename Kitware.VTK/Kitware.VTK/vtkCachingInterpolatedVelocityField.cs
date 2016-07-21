using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCachingInterpolatedVelocityField : vtkFunctionSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCachingInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkCachingInterpolatedVelocityField()
		{
			vtkCachingInterpolatedVelocityField.MRClassNameKey = "class vtkCachingInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCachingInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCachingInterpolatedVelocityField"));
		}

		public vtkCachingInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCachingInterpolatedVelocityField New()
		{
			vtkCachingInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCachingInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(HandleRef pThis);

		public void ClearLastCellInfo()
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f);

		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_FunctionValues_02(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_GetCacheMiss_03(HandleRef pThis);

		public virtual int GetCacheMiss()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetCacheMiss_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(HandleRef pThis);

		public virtual int GetCellCacheHit()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(HandleRef pThis);

		public virtual int GetDataSetCacheHit()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(HandleRef pThis, IntPtr pcoords);

		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_GetLastWeights_07(HandleRef pThis, IntPtr w);

		public int GetLastWeights(IntPtr w)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetLastWeights_07(base.GetCppThis(), w);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_GetVectorsSelection_08(HandleRef pThis);

		public virtual string GetVectorsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetVectorsSelection_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_InsideTest_09(HandleRef pThis, IntPtr x);

		public virtual int InsideTest(IntPtr x)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_InsideTest_09(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCachingInterpolatedVelocityField_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCachingInterpolatedVelocityField NewInstance()
		{
			vtkCachingInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCachingInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkCachingInterpolatedVelocityField vtkCachingInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCachingInterpolatedVelocityField = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCachingInterpolatedVelocityField.Register(null);
				}
			}
			return vtkCachingInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCachingInterpolatedVelocityField_SelectVectors_15(HandleRef pThis, string fieldName);

		public void SelectVectors(string fieldName)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SelectVectors_15(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCachingInterpolatedVelocityField_SetDataSet_16(HandleRef pThis, int I, HandleRef dataset, byte staticdataset, HandleRef locator);

		public virtual void SetDataSet(int I, vtkDataSet dataset, bool staticdataset, vtkAbstractCellLocator locator)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SetDataSet_16(base.GetCppThis(), I, (dataset == null) ? default(HandleRef) : dataset.GetCppThis(), staticdataset ? (byte)1 : (byte)0, (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCachingInterpolatedVelocityField_SetLastCellInfo_17(HandleRef pThis, long c, int datasetindex);

		public void SetLastCellInfo(long c, int datasetindex)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SetLastCellInfo_17(base.GetCppThis(), c, datasetindex);
		}
	}
}
