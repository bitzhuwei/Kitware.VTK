using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractBlock : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractBlock";

		public new static readonly string MRClassNameKey;

		static vtkExtractBlock()
		{
			vtkExtractBlock.MRClassNameKey = "class vtkExtractBlock";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractBlock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractBlock"));
		}

		public vtkExtractBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractBlock New()
		{
			vtkExtractBlock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractBlock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractBlock.vtkExtractBlock_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_AddIndex_01(HandleRef pThis, uint index);

		public void AddIndex(uint index)
		{
			vtkExtractBlock.vtkExtractBlock_AddIndex_01(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractBlock_GetMaintainStructure_02(HandleRef pThis);

		public virtual int GetMaintainStructure()
		{
			return vtkExtractBlock.vtkExtractBlock_GetMaintainStructure_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractBlock_GetPruneOutput_03(HandleRef pThis);

		public virtual int GetPruneOutput()
		{
			return vtkExtractBlock.vtkExtractBlock_GetPruneOutput_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractBlock_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractBlock_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractBlock.vtkExtractBlock_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_MaintainStructureOff_06(HandleRef pThis);

		public virtual void MaintainStructureOff()
		{
			vtkExtractBlock.vtkExtractBlock_MaintainStructureOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_MaintainStructureOn_07(HandleRef pThis);

		public virtual void MaintainStructureOn()
		{
			vtkExtractBlock.vtkExtractBlock_MaintainStructureOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractBlock_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractBlock NewInstance()
		{
			vtkExtractBlock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_PruneOutputOff_10(HandleRef pThis);

		public virtual void PruneOutputOff()
		{
			vtkExtractBlock.vtkExtractBlock_PruneOutputOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_PruneOutputOn_11(HandleRef pThis);

		public virtual void PruneOutputOn()
		{
			vtkExtractBlock.vtkExtractBlock_PruneOutputOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_RemoveAllIndices_12(HandleRef pThis);

		public void RemoveAllIndices()
		{
			vtkExtractBlock.vtkExtractBlock_RemoveAllIndices_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_RemoveIndex_13(HandleRef pThis, uint index);

		public void RemoveIndex(uint index)
		{
			vtkExtractBlock.vtkExtractBlock_RemoveIndex_13(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractBlock_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractBlock SafeDownCast(vtkObjectBase o)
		{
			vtkExtractBlock vtkExtractBlock = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractBlock.vtkExtractBlock_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractBlock = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractBlock.Register(null);
				}
			}
			return vtkExtractBlock;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_SetMaintainStructure_15(HandleRef pThis, int _arg);

		public virtual void SetMaintainStructure(int _arg)
		{
			vtkExtractBlock.vtkExtractBlock_SetMaintainStructure_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractBlock_SetPruneOutput_16(HandleRef pThis, int _arg);

		public virtual void SetPruneOutput(int _arg)
		{
			vtkExtractBlock.vtkExtractBlock_SetPruneOutput_16(base.GetCppThis(), _arg);
		}
	}
}
