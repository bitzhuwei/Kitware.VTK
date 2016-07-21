using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergePoints : vtkPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergePoints";

		public new static readonly string MRClassNameKey;

		static vtkMergePoints()
		{
			vtkMergePoints.MRClassNameKey = "class vtkMergePoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergePoints"));
		}

		public vtkMergePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMergePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergePoints New()
		{
			vtkMergePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergePoints.vtkMergePoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMergePoints_InsertUniquePoint_01(HandleRef pThis, IntPtr x, ref long ptId);

		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkMergePoints.vtkMergePoints_InsertUniquePoint_01(base.GetCppThis(), x, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMergePoints_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergePoints.vtkMergePoints_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMergePoints_IsInsertedPoint_03(HandleRef pThis, IntPtr x);

		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkMergePoints.vtkMergePoints_IsInsertedPoint_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMergePoints_IsInsertedPoint_04(HandleRef pThis, double x, double y, double z);

		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkMergePoints.vtkMergePoints_IsInsertedPoint_04(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMergePoints_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergePoints.vtkMergePoints_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMergePoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergePoints NewInstance()
		{
			vtkMergePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMergePoints_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergePoints SafeDownCast(vtkObjectBase o)
		{
			vtkMergePoints vtkMergePoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergePoints.vtkMergePoints_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergePoints = (vtkMergePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergePoints.Register(null);
				}
			}
			return vtkMergePoints;
		}
	}
}
