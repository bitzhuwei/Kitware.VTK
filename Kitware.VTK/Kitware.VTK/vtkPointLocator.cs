using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointLocator : vtkIncrementalPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointLocator";

		public new static readonly string MRClassNameKey;

		static vtkPointLocator()
		{
			vtkPointLocator.MRClassNameKey = "class vtkPointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLocator"));
		}

		public vtkPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointLocator New()
		{
			vtkPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointLocator.vtkPointLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkPointLocator.vtkPointLocator_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_FindClosestInsertedPoint_02(HandleRef pThis, IntPtr x);

		public override long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestInsertedPoint_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkPointLocator.vtkPointLocator_FindClosestNPoints_03(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

		public override long FindClosestPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPoint_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPointWithinRadius_05(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPointWithinRadius_06(base.GetCppThis(), radius, x, inputDataLength, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_FindDistributedPoints_07(HandleRef pThis, int N, IntPtr x, HandleRef result, int M);

		public virtual void FindDistributedPoints(int N, IntPtr x, vtkIdList result, int M)
		{
			vtkPointLocator.vtkPointLocator_FindDistributedPoints_07(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis(), M);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_FindDistributedPoints_08(HandleRef pThis, int N, double x, double y, double z, HandleRef result, int M);

		public virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList result, int M)
		{
			vtkPointLocator.vtkPointLocator_FindDistributedPoints_08(base.GetCppThis(), N, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis(), M);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_FindPointsWithinRadius_09(HandleRef pThis, double R, IntPtr x, HandleRef result);

		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkPointLocator.vtkPointLocator_FindPointsWithinRadius_09(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_FreeSearchStructure_10(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkPointLocator.vtkPointLocator_FreeSearchStructure_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_GenerateRepresentation_11(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkPointLocator.vtkPointLocator_GenerateRepresentation_11(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_GetDivisions_12(HandleRef pThis);

		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetDivisions_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_GetDivisions_13(HandleRef pThis, IntPtr data);

		public virtual void GetDivisions(IntPtr data)
		{
			vtkPointLocator.vtkPointLocator_GetDivisions_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucket_14(HandleRef pThis);

		public virtual int GetNumberOfPointsPerBucket()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucket_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_15(HandleRef pThis);

		public virtual int GetNumberOfPointsPerBucketMaxValue()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMinValue_16(HandleRef pThis);

		public virtual int GetNumberOfPointsPerBucketMinValue()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucketMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_GetPoints_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetPoints_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_GetPointsInBucket_18(HandleRef pThis, IntPtr x, IntPtr ijk, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdList GetPointsInBucket(IntPtr x, IntPtr ijk)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetPointsInBucket_18(base.GetCppThis(), x, ijk, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_InitPointInsertion_19(HandleRef pThis, HandleRef newPts, IntPtr bounds);

		public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
		{
			return vtkPointLocator.vtkPointLocator_InitPointInsertion_19(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_InitPointInsertion_20(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estSize);

		public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estSize)
		{
			return vtkPointLocator.vtkPointLocator_InitPointInsertion_20(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds, estSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_Initialize_21(HandleRef pThis);

		public override void Initialize()
		{
			vtkPointLocator.vtkPointLocator_Initialize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_InsertNextPoint_22(HandleRef pThis, IntPtr x);

		public override long InsertNextPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_InsertNextPoint_22(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_InsertPoint_23(HandleRef pThis, long ptId, IntPtr x);

		public override void InsertPoint(long ptId, IntPtr x)
		{
			vtkPointLocator.vtkPointLocator_InsertPoint_23(base.GetCppThis(), ptId, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_InsertUniquePoint_24(HandleRef pThis, IntPtr x, ref long ptId);

		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkPointLocator.vtkPointLocator_InsertUniquePoint_24(base.GetCppThis(), x, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointLocator.vtkPointLocator_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_IsInsertedPoint_26(HandleRef pThis, double x, double y, double z);

		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkPointLocator.vtkPointLocator_IsInsertedPoint_26(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPointLocator_IsInsertedPoint_27(HandleRef pThis, IntPtr x);

		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_IsInsertedPoint_27(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointLocator_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointLocator.vtkPointLocator_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointLocator NewInstance()
		{
			vtkPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLocator_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkPointLocator vtkPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointLocator = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointLocator.Register(null);
				}
			}
			return vtkPointLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_SetDivisions_32(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkPointLocator.vtkPointLocator_SetDivisions_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_SetDivisions_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkPointLocator.vtkPointLocator_SetDivisions_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointLocator_SetNumberOfPointsPerBucket_34(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPointsPerBucket(int _arg)
		{
			vtkPointLocator.vtkPointLocator_SetNumberOfPointsPerBucket_34(base.GetCppThis(), _arg);
		}
	}
}
