using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSpanTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpanTreeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkSpanTreeLayoutStrategy()
		{
			vtkSpanTreeLayoutStrategy.MRClassNameKey = "class vtkSpanTreeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpanTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpanTreeLayoutStrategy"));
		}

		public vtkSpanTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpanTreeLayoutStrategy New()
		{
			vtkSpanTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSpanTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(HandleRef pThis);

		public virtual void DepthFirstSpanningTreeOff()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(HandleRef pThis);

		public virtual void DepthFirstSpanningTreeOn()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(HandleRef pThis);

		public virtual bool GetDepthFirstSpanningTree()
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSpanTreeLayoutStrategy_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSpanTreeLayoutStrategy_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSpanTreeLayoutStrategy_Layout_06(HandleRef pThis);

		public override void Layout()
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_Layout_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpanTreeLayoutStrategy NewInstance()
		{
			vtkSpanTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSpanTreeLayoutStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpanTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSpanTreeLayoutStrategy vtkSpanTreeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpanTreeLayoutStrategy = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpanTreeLayoutStrategy.Register(null);
				}
			}
			return vtkSpanTreeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_10(HandleRef pThis, byte _arg);

		public virtual void SetDepthFirstSpanningTree(bool _arg)
		{
			vtkSpanTreeLayoutStrategy.vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
