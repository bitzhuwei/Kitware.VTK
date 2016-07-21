using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericInterpolatedVelocityField : vtkFunctionSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkGenericInterpolatedVelocityField()
		{
			vtkGenericInterpolatedVelocityField.MRClassNameKey = "class vtkGenericInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericInterpolatedVelocityField"));
		}

		public vtkGenericInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericInterpolatedVelocityField New()
		{
			vtkGenericInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

		public virtual void AddDataSet(vtkGenericDataSet dataset)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_CachingOff_02(HandleRef pThis);

		public virtual void CachingOff()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CachingOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_CachingOn_03(HandleRef pThis);

		public virtual void CachingOn()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CachingOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_ClearLastCell_04(HandleRef pThis);

		public void ClearLastCell()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_ClearLastCell_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_CopyParameters_05(HandleRef pThis, HandleRef from);

		public virtual void CopyParameters(vtkGenericInterpolatedVelocityField from)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CopyParameters_05(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_FunctionValues_06(HandleRef pThis, IntPtr x, IntPtr f);

		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_FunctionValues_06(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCacheHit_07(HandleRef pThis);

		public virtual int GetCacheHit()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCacheHit_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCacheMiss_08(HandleRef pThis);

		public virtual int GetCacheMiss()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCacheMiss_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCaching_09(HandleRef pThis);

		public virtual int GetCaching()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCaching_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGenericAdaptorCell GetLastCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastCell_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericDataSet GetLastDataSet()
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastDataSet_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(HandleRef pThis, IntPtr pcoords);

		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetVectorsSelection_13(HandleRef pThis);

		public virtual string GetVectorsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetVectorsSelection_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericInterpolatedVelocityField_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericInterpolatedVelocityField NewInstance()
		{
			vtkGenericInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkGenericInterpolatedVelocityField vtkGenericInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericInterpolatedVelocityField = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericInterpolatedVelocityField.Register(null);
				}
			}
			return vtkGenericInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_SelectVectors_19(HandleRef pThis, string fieldName);

		public void SelectVectors(string fieldName)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SelectVectors_19(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericInterpolatedVelocityField_SetCaching_20(HandleRef pThis, int _arg);

		public virtual void SetCaching(int _arg)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SetCaching_20(base.GetCppThis(), _arg);
		}
	}
}
