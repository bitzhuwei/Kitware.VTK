using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkVisibilitySort : vtkObject
	{
		public enum BACK_TO_FRONT_WrapperEnum
		{
			BACK_TO_FRONT,
			FRONT_TO_BACK
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkVisibilitySort";

		public new static readonly string MRClassNameKey;

		static vtkVisibilitySort()
		{
			vtkVisibilitySort.MRClassNameKey = "class vtkVisibilitySort";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVisibilitySort.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVisibilitySort"));
		}

		public vtkVisibilitySort(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_Register_14(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkVisibilitySort.vtkVisibilitySort_Register_14(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_UnRegister_23(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkVisibilitySort.vtkVisibilitySort_UnRegister_23(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetCamera_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_GetDirection_02(HandleRef pThis);

		public virtual int GetDirection()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetDirection_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_GetInverseModelTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetInverseModelTransform()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetInverseModelTransform_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturned_05(HandleRef pThis);

		public virtual int GetMaxCellsReturned()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturned_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(HandleRef pThis);

		public virtual int GetMaxCellsReturnedMaxValue()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturnedMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(HandleRef pThis);

		public virtual int GetMaxCellsReturnedMinValue()
		{
			return vtkVisibilitySort.vtkVisibilitySort_GetMaxCellsReturnedMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_GetModelTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetModelTransform()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetModelTransform_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_GetNextCells_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdTypeArray GetNextCells()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_GetNextCells_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_InitTraversal_10(HandleRef pThis);

		public virtual void InitTraversal()
		{
			vtkVisibilitySort.vtkVisibilitySort_InitTraversal_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibilitySort_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVisibilitySort.vtkVisibilitySort_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVisibilitySort NewInstance()
		{
			vtkVisibilitySort result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibilitySort_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVisibilitySort SafeDownCast(vtkObjectBase o)
		{
			vtkVisibilitySort vtkVisibilitySort = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibilitySort.vtkVisibilitySort_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVisibilitySort = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVisibilitySort.Register(null);
				}
			}
			return vtkVisibilitySort;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetCamera_16(HandleRef pThis, HandleRef camera);

		public virtual void SetCamera(vtkCamera camera)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetCamera_16(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetDirection_17(HandleRef pThis, int _arg);

		public virtual void SetDirection(int _arg)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirection_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetDirectionToBackToFront_18(HandleRef pThis);

		public void SetDirectionToBackToFront()
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirectionToBackToFront_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetDirectionToFrontToBack_19(HandleRef pThis);

		public void SetDirectionToFrontToBack()
		{
			vtkVisibilitySort.vtkVisibilitySort_SetDirectionToFrontToBack_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetInput_20(HandleRef pThis, HandleRef data);

		public virtual void SetInput(vtkDataSet data)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetInput_20(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetMaxCellsReturned_21(HandleRef pThis, int _arg);

		public virtual void SetMaxCellsReturned(int _arg)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetMaxCellsReturned_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibilitySort_SetModelTransform_22(HandleRef pThis, HandleRef mat);

		public virtual void SetModelTransform(vtkMatrix4x4 mat)
		{
			vtkVisibilitySort.vtkVisibilitySort_SetModelTransform_22(base.GetCppThis(), (mat == null) ? default(HandleRef) : mat.GetCppThis());
		}
	}
}
