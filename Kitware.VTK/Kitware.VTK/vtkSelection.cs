using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSelection : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelection";

		public new static readonly string MRClassNameKey;

		static vtkSelection()
		{
			vtkSelection.MRClassNameKey = "class vtkSelection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelection"));
		}

		public vtkSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelection New()
		{
			vtkSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSelection.vtkSelection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_AddNode_01(HandleRef pThis, HandleRef arg0);

		public virtual void AddNode(vtkSelectionNode arg0)
		{
			vtkSelection.vtkSelection_AddNode_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_DeepCopy_02(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkSelection.vtkSelection_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_Dump_03(HandleRef pThis);

		public virtual void Dump()
		{
			vtkSelection.vtkSelection_Dump_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelection GetData(vtkInformation info)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_GetData_04((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelection GetData(vtkInformationVector v, int i)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_GetData_05((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSelection_GetDataObjectType_06(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkSelection.vtkSelection_GetDataObjectType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkSelection_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSelection.vtkSelection_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_GetNode_08(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelectionNode GetNode(uint idx)
		{
			vtkSelectionNode vtkSelectionNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_GetNode_08(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionNode = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionNode.Register(null);
				}
			}
			return vtkSelectionNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkSelection_GetNumberOfNodes_09(HandleRef pThis);

		public uint GetNumberOfNodes()
		{
			return vtkSelection.vtkSelection_GetNumberOfNodes_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_Initialize_10(HandleRef pThis);

		public override void Initialize()
		{
			vtkSelection.vtkSelection_Initialize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSelection_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSelection.vtkSelection_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSelection_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSelection.vtkSelection_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSelection NewInstance()
		{
			vtkSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_RemoveAllNodes_15(HandleRef pThis);

		public virtual void RemoveAllNodes()
		{
			vtkSelection.vtkSelection_RemoveAllNodes_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_RemoveNode_16(HandleRef pThis, uint idx);

		public virtual void RemoveNode(uint idx)
		{
			vtkSelection.vtkSelection_RemoveNode_16(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_RemoveNode_17(HandleRef pThis, HandleRef arg0);

		public virtual void RemoveNode(vtkSelectionNode arg0)
		{
			vtkSelection.vtkSelection_RemoveNode_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelection_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelection SafeDownCast(vtkObjectBase o)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelection.vtkSelection_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_ShallowCopy_19(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkSelection.vtkSelection_ShallowCopy_19(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_Union_20(HandleRef pThis, HandleRef selection);

		public virtual void Union(vtkSelection selection)
		{
			vtkSelection.vtkSelection_Union_20(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSelection_Union_21(HandleRef pThis, HandleRef node);

		public virtual void Union(vtkSelectionNode node)
		{
			vtkSelection.vtkSelection_Union_21(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}
	}
}
