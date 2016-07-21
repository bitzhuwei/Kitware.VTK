using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalBoxDataSetAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataSetAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalBoxDataSetAlgorithm()
		{
			vtkHierarchicalBoxDataSetAlgorithm.MRClassNameKey = "class vtkHierarchicalBoxDataSetAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataSetAlgorithm"));
		}

		public vtkHierarchicalBoxDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSetAlgorithm New()
		{
			vtkHierarchicalBoxDataSetAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalBoxDataSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHierarchicalBoxDataSet GetOutput()
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_GetOutput_02(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHierarchicalBoxDataSet GetOutput(int arg0)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetOutput_02(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSetAlgorithm_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSetAlgorithm_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalBoxDataSetAlgorithm NewInstance()
		{
			vtkHierarchicalBoxDataSetAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataSetAlgorithm vtkHierarchicalBoxDataSetAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSetAlgorithm = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSetAlgorithm.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSetAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSetAlgorithm_SetInput_08(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SetInput_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSetAlgorithm_SetInput_09(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SetInput_09(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}
	}
}
