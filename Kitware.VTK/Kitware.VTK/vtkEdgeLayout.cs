using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEdgeLayout : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeLayout";

		public new static readonly string MRClassNameKey;

		static vtkEdgeLayout()
		{
			vtkEdgeLayout.MRClassNameKey = "class vtkEdgeLayout";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeLayout"));
		}

		public vtkEdgeLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeLayout New()
		{
			vtkEdgeLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEdgeLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEdgeLayout.vtkEdgeLayout_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayout_GetLayoutStrategy_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEdgeLayoutStrategy GetLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_GetLayoutStrategy_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkEdgeLayout_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkEdgeLayout.vtkEdgeLayout_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeLayout_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeLayout_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayout_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgeLayout NewInstance()
		{
			vtkEdgeLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayout_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeLayout SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeLayout vtkEdgeLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayout = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayout.Register(null);
				}
			}
			return vtkEdgeLayout;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeLayout_SetLayoutStrategy_08(HandleRef pThis, HandleRef strategy);

		public void SetLayoutStrategy(vtkEdgeLayoutStrategy strategy)
		{
			vtkEdgeLayout.vtkEdgeLayout_SetLayoutStrategy_08(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}
	}
}
