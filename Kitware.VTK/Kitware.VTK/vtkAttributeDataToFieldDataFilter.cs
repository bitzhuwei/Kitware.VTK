using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAttributeDataToFieldDataFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeDataToFieldDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkAttributeDataToFieldDataFilter()
		{
			vtkAttributeDataToFieldDataFilter.MRClassNameKey = "class vtkAttributeDataToFieldDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeDataToFieldDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeDataToFieldDataFilter"));
		}

		public vtkAttributeDataToFieldDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributeDataToFieldDataFilter New()
		{
			vtkAttributeDataToFieldDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAttributeDataToFieldDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAttributeDataToFieldDataFilter_GetPassAttributeData_01(HandleRef pThis);

		public virtual int GetPassAttributeData()
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_GetPassAttributeData_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAttributeDataToFieldDataFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAttributeDataToFieldDataFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAttributeDataToFieldDataFilter NewInstance()
		{
			vtkAttributeDataToFieldDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_06(HandleRef pThis);

		public virtual void PassAttributeDataOff()
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_07(HandleRef pThis);

		public virtual void PassAttributeDataOn()
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeDataToFieldDataFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributeDataToFieldDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeDataToFieldDataFilter vtkAttributeDataToFieldDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeDataToFieldDataFilter = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeDataToFieldDataFilter.Register(null);
				}
			}
			return vtkAttributeDataToFieldDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAttributeDataToFieldDataFilter_SetPassAttributeData_09(HandleRef pThis, int _arg);

		public virtual void SetPassAttributeData(int _arg)
		{
			vtkAttributeDataToFieldDataFilter.vtkAttributeDataToFieldDataFilter_SetPassAttributeData_09(base.GetCppThis(), _arg);
		}
	}
}
