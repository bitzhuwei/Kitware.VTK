using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractInterpolatedVelocityField : vtkFunctionSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkAbstractInterpolatedVelocityField()
		{
			vtkAbstractInterpolatedVelocityField.MRClassNameKey = "class vtkAbstractInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractInterpolatedVelocityField"));
		}

		public vtkAbstractInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

		public virtual void AddDataSet(vtkDataSet dataset)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_ClearLastCellId_02(HandleRef pThis);

		public void ClearLastCellId()
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_ClearLastCellId_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_CopyParameters_03(HandleRef pThis, HandleRef from);

		public virtual void CopyParameters(vtkAbstractInterpolatedVelocityField from)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_CopyParameters_03(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_FunctionValues_04(HandleRef pThis, IntPtr x, IntPtr f);

		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_FunctionValues_04(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheHit_05(HandleRef pThis);

		public virtual int GetCacheHit()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCacheHit_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheMiss_06(HandleRef pThis);

		public virtual int GetCacheMiss()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCacheMiss_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetCaching_07(HandleRef pThis);

		public virtual bool GetCaching()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetCaching_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractInterpolatedVelocityField_GetLastCellId_08(HandleRef pThis);

		public virtual long GetLastCellId()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastCellId_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetLastDataSet_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetLastDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastDataSet_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetLastDataSetIndex_10(HandleRef pThis);

		public virtual int GetLastDataSetIndex()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastDataSetIndex_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_11(HandleRef pThis, IntPtr pcoords);

		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_11(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_GetLastWeights_12(HandleRef pThis, IntPtr w);

		public int GetLastWeights(IntPtr w)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetLastWeights_12(base.GetCppThis(), w);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkAbstractInterpolatedVelocityField_GetNormalizeVector_13(HandleRef pThis);

		public virtual bool GetNormalizeVector()
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetNormalizeVector_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetVectorsSelection_14(HandleRef pThis);

		public virtual string GetVectorsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_GetVectorsSelection_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractInterpolatedVelocityField_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractInterpolatedVelocityField NewInstance()
		{
			vtkAbstractInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractInterpolatedVelocityField_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractInterpolatedVelocityField vtkAbstractInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractInterpolatedVelocityField = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractInterpolatedVelocityField.Register(null);
				}
			}
			return vtkAbstractInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_SelectVectors_19(HandleRef pThis, string fieldName);

		public void SelectVectors(string fieldName)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SelectVectors_19(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetCaching_20(HandleRef pThis, byte _arg);

		public virtual void SetCaching(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetCaching_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_21(HandleRef pThis, long c);

		public virtual void SetLastCellId(long c)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetLastCellId_21(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_22(HandleRef pThis, long c, int dataindex);

		public virtual void SetLastCellId(long c, int dataindex)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetLastCellId_22(base.GetCppThis(), c, dataindex);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractInterpolatedVelocityField_SetNormalizeVector_23(HandleRef pThis, byte _arg);

		public virtual void SetNormalizeVector(bool _arg)
		{
			vtkAbstractInterpolatedVelocityField.vtkAbstractInterpolatedVelocityField_SetNormalizeVector_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
