using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCosmicTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCosmicTreeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkCosmicTreeLayoutStrategy()
		{
			vtkCosmicTreeLayoutStrategy.MRClassNameKey = "class vtkCosmicTreeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCosmicTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCosmicTreeLayoutStrategy"));
		}

		public vtkCosmicTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCosmicTreeLayoutStrategy New()
		{
			vtkCosmicTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCosmicTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(HandleRef pThis);

		public virtual int GetLayoutDepth()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(HandleRef pThis);

		public virtual long GetLayoutRoot()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(HandleRef pThis);

		public virtual string GetNodeSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_04(HandleRef pThis);

		public virtual int GetSizeLeafNodesOnly()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCosmicTreeLayoutStrategy_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCosmicTreeLayoutStrategy_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_Layout_07(HandleRef pThis);

		public override void Layout()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_Layout_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCosmicTreeLayoutStrategy NewInstance()
		{
			vtkCosmicTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCosmicTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCosmicTreeLayoutStrategy vtkCosmicTreeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCosmicTreeLayoutStrategy = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCosmicTreeLayoutStrategy.Register(null);
				}
			}
			return vtkCosmicTreeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutDepth_11(HandleRef pThis, int _arg);

		public virtual void SetLayoutDepth(int _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetLayoutDepth_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutRoot_12(HandleRef pThis, long _arg);

		public virtual void SetLayoutRoot(long _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetLayoutRoot_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_13(HandleRef pThis, string _arg);

		public virtual void SetNodeSizeArrayName(string _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_14(HandleRef pThis, int _arg);

		public virtual void SetSizeLeafNodesOnly(int _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_15(HandleRef pThis);

		public virtual void SizeLeafNodesOnlyOff()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_16(HandleRef pThis);

		public virtual void SizeLeafNodesOnlyOn()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_16(base.GetCppThis());
		}
	}
}
