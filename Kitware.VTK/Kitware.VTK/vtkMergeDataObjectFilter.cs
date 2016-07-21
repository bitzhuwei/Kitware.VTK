using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeDataObjectFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeDataObjectFilter";

		public new static readonly string MRClassNameKey;

		static vtkMergeDataObjectFilter()
		{
			vtkMergeDataObjectFilter.MRClassNameKey = "class vtkMergeDataObjectFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeDataObjectFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeDataObjectFilter"));
		}

		public vtkMergeDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeDataObjectFilter New()
		{
			vtkMergeDataObjectFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeDataObjectFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeDataObjectFilter_GetDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetDataObject_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeDataObjectFilter_GetOutputField_02(HandleRef pThis);

		public virtual int GetOutputField()
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_GetOutputField_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeDataObjectFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeDataObjectFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeDataObjectFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeDataObjectFilter NewInstance()
		{
			vtkMergeDataObjectFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeDataObjectFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeDataObjectFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMergeDataObjectFilter vtkMergeDataObjectFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeDataObjectFilter = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeDataObjectFilter.Register(null);
				}
			}
			return vtkMergeDataObjectFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeDataObjectFilter_SetDataObject_08(HandleRef pThis, HandleRef arg0);

		public void SetDataObject(vtkDataObject arg0)
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetDataObject_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeDataObjectFilter_SetOutputField_09(HandleRef pThis, int _arg);

		public virtual void SetOutputField(int _arg)
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputField_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_10(HandleRef pThis);

		public void SetOutputFieldToCellDataField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_11(HandleRef pThis);

		public void SetOutputFieldToDataObjectField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_12(HandleRef pThis);

		public void SetOutputFieldToPointDataField()
		{
			vtkMergeDataObjectFilter.vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_12(base.GetCppThis());
		}
	}
}
