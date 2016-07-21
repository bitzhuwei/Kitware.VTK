using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTreeNode : vtkObject
	{
		public enum NodeStatus
		{
			NONE,
			PROCESSING
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTreeNode";

		public new static readonly string MRClassNameKey;

		static vtkGeoTreeNode()
		{
			vtkGeoTreeNode.MRClassNameKey = "class vtkGeoTreeNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTreeNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTreeNode"));
		}

		public vtkGeoTreeNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTreeNode New()
		{
			vtkGeoTreeNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTreeNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTreeNode.vtkGeoTreeNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNode_CreateChildren_01(HandleRef pThis);

		public int CreateChildren()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_CreateChildren_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_DeepCopy_02(HandleRef pThis, HandleRef src);

		public virtual void DeepCopy(vtkGeoTreeNode src)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_DeleteData_03(HandleRef pThis);

		public virtual void DeleteData()
		{
			vtkGeoTreeNode.vtkGeoTreeNode_DeleteData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetChildTreeNode_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTreeNode GetChildTreeNode(int idx)
		{
			vtkGeoTreeNode vtkGeoTreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetChildTreeNode_04(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNode = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNode.Register(null);
				}
			}
			return vtkGeoTreeNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern uint vtkGeoTreeNode_GetId_05(HandleRef pThis);

		public virtual uint GetId()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_GetId_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetLatitudeRange_06(HandleRef pThis);

		public virtual double[] GetLatitudeRange()
		{
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetLatitudeRange_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_GetLatitudeRange_07(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLatitudeRange(ref double _arg1, ref double _arg2)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_GetLatitudeRange_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_GetLatitudeRange_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetLatitudeRange(IntPtr _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_GetLatitudeRange_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNode_GetLevel_09(HandleRef pThis);

		public virtual int GetLevel()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_GetLevel_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetLongitudeRange_10(HandleRef pThis);

		public virtual double[] GetLongitudeRange()
		{
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetLongitudeRange_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_GetLongitudeRange_11(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLongitudeRange(ref double _arg1, ref double _arg2)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_GetLongitudeRange_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_GetLongitudeRange_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetLongitudeRange(IntPtr _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_GetLongitudeRange_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetNewer_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTreeNode GetNewer()
		{
			vtkGeoTreeNode vtkGeoTreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetNewer_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNode = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNode.Register(null);
				}
			}
			return vtkGeoTreeNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetOlder_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTreeNode GetOlder()
		{
			vtkGeoTreeNode vtkGeoTreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetOlder_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNode = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNode.Register(null);
				}
			}
			return vtkGeoTreeNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_GetParentTreeNode_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTreeNode GetParentTreeNode()
		{
			vtkGeoTreeNode vtkGeoTreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_GetParentTreeNode_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNode = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNode.Register(null);
				}
			}
			return vtkGeoTreeNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern vtkGeoTreeNode.NodeStatus vtkGeoTreeNode_GetStatus_16(HandleRef pThis);

		public vtkGeoTreeNode.NodeStatus GetStatus()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_GetStatus_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNode_GetWhichChildAreYou_17(HandleRef pThis);

		public int GetWhichChildAreYou()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_GetWhichChildAreYou_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoTreeNode_HasData_18(HandleRef pThis);

		public virtual bool HasData()
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_HasData_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNode_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoTreeNode_IsDescendantOf_20(HandleRef pThis, HandleRef elder);

		public bool IsDescendantOf(vtkGeoTreeNode elder)
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_IsDescendantOf_20(base.GetCppThis(), (elder == null) ? default(HandleRef) : elder.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNode_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTreeNode.vtkGeoTreeNode_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTreeNode NewInstance()
		{
			vtkGeoTreeNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNode_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTreeNode SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTreeNode vtkGeoTreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNode.vtkGeoTreeNode_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNode = (vtkGeoTreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNode.Register(null);
				}
			}
			return vtkGeoTreeNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetChild_25(HandleRef pThis, HandleRef node, int idx);

		public void SetChild(vtkGeoTreeNode node, int idx)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetChild_25(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetId_26(HandleRef pThis, uint _arg);

		public virtual void SetId(uint _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetId_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetLatitudeRange_27(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLatitudeRange(double _arg1, double _arg2)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetLatitudeRange_27(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetLatitudeRange_28(HandleRef pThis, IntPtr _arg);

		public void SetLatitudeRange(IntPtr _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetLatitudeRange_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetLevel_29(HandleRef pThis, int _arg);

		public virtual void SetLevel(int _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetLevel_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetLongitudeRange_30(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLongitudeRange(double _arg1, double _arg2)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetLongitudeRange_30(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetLongitudeRange_31(HandleRef pThis, IntPtr _arg);

		public void SetLongitudeRange(IntPtr _arg)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetLongitudeRange_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetNewer_32(HandleRef pThis, HandleRef node);

		public void SetNewer(vtkGeoTreeNode node)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetNewer_32(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetOlder_33(HandleRef pThis, HandleRef node);

		public void SetOlder(vtkGeoTreeNode node)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetOlder_33(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetParent_34(HandleRef pThis, HandleRef node);

		public void SetParent(vtkGeoTreeNode node)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetParent_34(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_SetStatus_35(HandleRef pThis, vtkGeoTreeNode.NodeStatus status);

		public void SetStatus(vtkGeoTreeNode.NodeStatus status)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_SetStatus_35(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNode_ShallowCopy_36(HandleRef pThis, HandleRef src);

		public virtual void ShallowCopy(vtkGeoTreeNode src)
		{
			vtkGeoTreeNode.vtkGeoTreeNode_ShallowCopy_36(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}
