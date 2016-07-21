using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWeightedTransformFilter : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWeightedTransformFilter";

		public new static readonly string MRClassNameKey;

		static vtkWeightedTransformFilter()
		{
			vtkWeightedTransformFilter.MRClassNameKey = "class vtkWeightedTransformFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWeightedTransformFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWeightedTransformFilter"));
		}

		public vtkWeightedTransformFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWeightedTransformFilter New()
		{
			vtkWeightedTransformFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWeightedTransformFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWeightedTransformFilter.vtkWeightedTransformFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_AddInputValuesOff_01(HandleRef pThis);

		public virtual void AddInputValuesOff()
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_AddInputValuesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_AddInputValuesOn_02(HandleRef pThis);

		public virtual void AddInputValuesOn()
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_AddInputValuesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWeightedTransformFilter_GetAddInputValues_03(HandleRef pThis);

		public virtual int GetAddInputValues()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetAddInputValues_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(HandleRef pThis);

		public virtual string GetCellDataTransformIndexArray()
		{
			return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataWeightArray_05(HandleRef pThis);

		public virtual string GetCellDataWeightArray()
		{
			return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetCellDataWeightArray_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkWeightedTransformFilter_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWeightedTransformFilter_GetNumberOfTransforms_07(HandleRef pThis);

		public virtual int GetNumberOfTransforms()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetNumberOfTransforms_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_GetTransform_08(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform(int num)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetTransform_08(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_GetTransformIndexArray_09(HandleRef pThis);

		public virtual string GetTransformIndexArray()
		{
			return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetTransformIndexArray_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_GetWeightArray_10(HandleRef pThis);

		public virtual string GetWeightArray()
		{
			return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetWeightArray_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWeightedTransformFilter_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWeightedTransformFilter_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWeightedTransformFilter NewInstance()
		{
			vtkWeightedTransformFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWeightedTransformFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWeightedTransformFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWeightedTransformFilter vtkWeightedTransformFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWeightedTransformFilter = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWeightedTransformFilter.Register(null);
				}
			}
			return vtkWeightedTransformFilter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetAddInputValues_16(HandleRef pThis, int _arg);

		public virtual void SetAddInputValues(int _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetAddInputValues_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetCellDataTransformIndexArray_17(HandleRef pThis, string _arg);

		public virtual void SetCellDataTransformIndexArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetCellDataTransformIndexArray_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetCellDataWeightArray_18(HandleRef pThis, string _arg);

		public virtual void SetCellDataWeightArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetCellDataWeightArray_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetNumberOfTransforms_19(HandleRef pThis, int num);

		public virtual void SetNumberOfTransforms(int num)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetNumberOfTransforms_19(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetTransform_20(HandleRef pThis, HandleRef transform, int num);

		public virtual void SetTransform(vtkAbstractTransform transform, int num)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetTransform_20(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetTransformIndexArray_21(HandleRef pThis, string _arg);

		public virtual void SetTransformIndexArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetTransformIndexArray_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWeightedTransformFilter_SetWeightArray_22(HandleRef pThis, string _arg);

		public virtual void SetWeightArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetWeightArray_22(base.GetCppThis(), _arg);
		}
	}
}
