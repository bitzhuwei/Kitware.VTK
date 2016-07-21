using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectionBase : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectionBase";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectionBase()
		{
			vtkExtractSelectionBase.MRClassNameKey = "class vtkExtractSelectionBase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectionBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectionBase"));
		}

		public vtkExtractSelectionBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectionBase_GetPreserveTopology_01(HandleRef pThis);

		public virtual int GetPreserveTopology()
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_GetPreserveTopology_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectionBase_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectionBase_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectionBase.vtkExtractSelectionBase_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectionBase_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectionBase NewInstance()
		{
			vtkExtractSelectionBase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectionBase.vtkExtractSelectionBase_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectionBase_PreserveTopologyOff_05(HandleRef pThis);

		public virtual void PreserveTopologyOff()
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_PreserveTopologyOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectionBase_PreserveTopologyOn_06(HandleRef pThis);

		public virtual void PreserveTopologyOn()
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_PreserveTopologyOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectionBase_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectionBase SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectionBase vtkExtractSelectionBase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectionBase.vtkExtractSelectionBase_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectionBase = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectionBase.Register(null);
				}
			}
			return vtkExtractSelectionBase;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectionBase_SetPreserveTopology_08(HandleRef pThis, int _arg);

		public virtual void SetPreserveTopology(int _arg)
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_SetPreserveTopology_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectionBase_SetSelectionConnection_09(HandleRef pThis, HandleRef algOutput);

		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkExtractSelectionBase.vtkExtractSelectionBase_SetSelectionConnection_09(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}
	}
}
