using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKMeansDistanceFunctor : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctor";

		public new static readonly string MRClassNameKey;

		static vtkKMeansDistanceFunctor()
		{
			vtkKMeansDistanceFunctor.MRClassNameKey = "class vtkKMeansDistanceFunctor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansDistanceFunctor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctor"));
		}

		public vtkKMeansDistanceFunctor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansDistanceFunctor New()
		{
			vtkKMeansDistanceFunctor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKMeansDistanceFunctor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_AllocateElementArray_01(HandleRef pThis, long size);

		public virtual IntPtr AllocateElementArray(long size)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_AllocateElementArray_01(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_CreateCoordinateArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractArray CreateCoordinateArray()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_CreateCoordinateArray_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_DeallocateElementArray_03(HandleRef pThis, IntPtr arg0);

		public virtual void DeallocateElementArray(IntPtr arg0)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_DeallocateElementArray_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansDistanceFunctor_GetDataType_04(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetDataType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_GetEmptyTuple_05(HandleRef pThis, long dimension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkVariantArray GetEmptyTuple(long dimension)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetEmptyTuple_05(base.GetCppThis(), dimension, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansDistanceFunctor_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkKMeansDistanceFunctor_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKMeansDistanceFunctor NewInstance()
		{
			vtkKMeansDistanceFunctor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_PackElements_10(HandleRef pThis, HandleRef curTable, IntPtr vElements);

		public virtual void PackElements(vtkTable curTable, IntPtr vElements)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PackElements_10(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), vElements);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_PairwiseUpdate_11(HandleRef pThis, HandleRef clusterCenters, long row, HandleRef data, long dataCardinality, long totalCardinality);

		public virtual void PairwiseUpdate(vtkTable clusterCenters, long row, vtkVariantArray data, long dataCardinality, long totalCardinality)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PairwiseUpdate_11(base.GetCppThis(), (clusterCenters == null) ? default(HandleRef) : clusterCenters.GetCppThis(), row, (data == null) ? default(HandleRef) : data.GetCppThis(), dataCardinality, totalCardinality);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_PerturbElement_12(HandleRef pThis, HandleRef arg0, HandleRef arg1, long arg2, long arg3, long arg4, double arg5);

		public virtual void PerturbElement(vtkTable arg0, vtkTable arg1, long arg2, long arg3, long arg4, double arg5)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PerturbElement_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, arg4, arg5);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkKMeansDistanceFunctor_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKMeansDistanceFunctor SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctor = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctor.Register(null);
				}
			}
			return vtkKMeansDistanceFunctor;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_UnPackElements_14(HandleRef pThis, HandleRef curTable, HandleRef newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np);

		public virtual void UnPackElements(vtkTable curTable, vtkTable newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_UnPackElements_14(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), (newTable == null) ? default(HandleRef) : newTable.GetCppThis(), vLocalElements, vGlobalElements, np);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkKMeansDistanceFunctor_UnPackElements_15(HandleRef pThis, HandleRef curTable, IntPtr vLocalElements, long numRows, long numCols);

		public virtual void UnPackElements(vtkTable curTable, IntPtr vLocalElements, long numRows, long numCols)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_UnPackElements_15(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), vLocalElements, numRows, numCols);
		}
	}
}
