using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkComputeHistogram2DOutliers : vtkSelectionAlgorithm
	{
		public enum InputPorts
		{
			INPUT_HISTOGRAMS_IMAGE_DATA = 1,
			INPUT_HISTOGRAMS_MULTIBLOCK,
			INPUT_TABLE_DATA = 0
		}

		public enum OutputPorts
		{
			OUTPUT_SELECTED_ROWS,
			OUTPUT_SELECTED_TABLE_DATA
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkComputeHistogram2DOutliers";

		public new static readonly string MRClassNameKey;

		static vtkComputeHistogram2DOutliers()
		{
			vtkComputeHistogram2DOutliers.MRClassNameKey = "class vtkComputeHistogram2DOutliers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkComputeHistogram2DOutliers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputeHistogram2DOutliers"));
		}

		public vtkComputeHistogram2DOutliers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkComputeHistogram2DOutliers New()
		{
			vtkComputeHistogram2DOutliers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkComputeHistogram2DOutliers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_GetOutputTable_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTable GetOutputTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetOutputTable_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_02(HandleRef pThis);

		public virtual int GetPreferredNumberOfOutliers()
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_GetPreferredNumberOfOutliers_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkComputeHistogram2DOutliers_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkComputeHistogram2DOutliers_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkComputeHistogram2DOutliers NewInstance()
		{
			vtkComputeHistogram2DOutliers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkComputeHistogram2DOutliers_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkComputeHistogram2DOutliers SafeDownCast(vtkObjectBase o)
		{
			vtkComputeHistogram2DOutliers vtkComputeHistogram2DOutliers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputeHistogram2DOutliers = (vtkComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputeHistogram2DOutliers.Register(null);
				}
			}
			return vtkComputeHistogram2DOutliers;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_08(HandleRef pThis, HandleRef cxn);

		public void SetInputHistogramImageDataConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputHistogramImageDataConnection_08(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_09(HandleRef pThis, HandleRef cxn);

		public void SetInputHistogramMultiBlockConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputHistogramMultiBlockConnection_09(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkComputeHistogram2DOutliers_SetInputTableConnection_10(HandleRef pThis, HandleRef cxn);

		public void SetInputTableConnection(vtkAlgorithmOutput cxn)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetInputTableConnection_10(base.GetCppThis(), (cxn == null) ? default(HandleRef) : cxn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_11(HandleRef pThis, int _arg);

		public virtual void SetPreferredNumberOfOutliers(int _arg)
		{
			vtkComputeHistogram2DOutliers.vtkComputeHistogram2DOutliers_SetPreferredNumberOfOutliers_11(base.GetCppThis(), _arg);
		}
	}
}
