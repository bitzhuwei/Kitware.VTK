using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProcrustesAlignmentFilter : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcrustesAlignmentFilter";

		public new static readonly string MRClassNameKey;

		static vtkProcrustesAlignmentFilter()
		{
			vtkProcrustesAlignmentFilter.MRClassNameKey = "class vtkProcrustesAlignmentFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcrustesAlignmentFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcrustesAlignmentFilter"));
		}

		public vtkProcrustesAlignmentFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcrustesAlignmentFilter New()
		{
			vtkProcrustesAlignmentFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProcrustesAlignmentFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_GetInput_01(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPointSet GetInput(int idx)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetInput_01(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkProcrustesAlignmentFilter_GetLandmarkTransform_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLandmarkTransform GetLandmarkTransform()
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetLandmarkTransform_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLandmarkTransform = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLandmarkTransform.Register(null);
				}
			}
			return vtkLandmarkTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_GetMeanPoints_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetMeanPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetMeanPoints_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern byte vtkProcrustesAlignmentFilter_GetStartFromCentroid_04(HandleRef pThis);

		public virtual bool GetStartFromCentroid()
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_GetStartFromCentroid_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProcrustesAlignmentFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProcrustesAlignmentFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProcrustesAlignmentFilter NewInstance()
		{
			vtkProcrustesAlignmentFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProcrustesAlignmentFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcrustesAlignmentFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProcrustesAlignmentFilter vtkProcrustesAlignmentFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcrustesAlignmentFilter = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcrustesAlignmentFilter.Register(null);
				}
			}
			return vtkProcrustesAlignmentFilter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_SetInput_10(HandleRef pThis, int idx, HandleRef p);

		public new void SetInput(int idx, vtkPointSet p)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetInput_10(base.GetCppThis(), idx, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_SetInput_11(HandleRef pThis, int idx, HandleRef input);

		public new void SetInput(int idx, vtkDataObject input)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetInput_11(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_SetNumberOfInputs_12(HandleRef pThis, int n);

		public void SetNumberOfInputs(int n)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetNumberOfInputs_12(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(HandleRef pThis, byte _arg);

		public virtual void SetStartFromCentroid(bool _arg)
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(HandleRef pThis);

		public virtual void StartFromCentroidOff()
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(HandleRef pThis);

		public virtual void StartFromCentroidOn()
		{
			vtkProcrustesAlignmentFilter.vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(base.GetCppThis());
		}
	}
}
