using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCollectGraph : vtkGraphAlgorithm
	{
		public enum DIRECTED_OUTPUT_WrapperEnum
		{
			DIRECTED_OUTPUT,
			UNDIRECTED_OUTPUT,
			USE_INPUT_TYPE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectGraph";

		public new static readonly string MRClassNameKey;

		static vtkCollectGraph()
		{
			vtkCollectGraph.MRClassNameKey = "class vtkCollectGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectGraph"));
		}

		public vtkCollectGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollectGraph New()
		{
			vtkCollectGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCollectGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCollectGraph.vtkCollectGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectGraph_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCollectGraph_GetOutputType_02(HandleRef pThis);

		public virtual int GetOutputType()
		{
			return vtkCollectGraph.vtkCollectGraph_GetOutputType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCollectGraph_GetPassThrough_03(HandleRef pThis);

		public virtual int GetPassThrough()
		{
			return vtkCollectGraph.vtkCollectGraph_GetPassThrough_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectGraph_GetSocketController_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSocketController GetSocketController()
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_GetSocketController_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketController = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketController.Register(null);
				}
			}
			return vtkSocketController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCollectGraph_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCollectGraph_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCollectGraph.vtkCollectGraph_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectGraph_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCollectGraph NewInstance()
		{
			vtkCollectGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_PassThroughOff_09(HandleRef pThis);

		public virtual void PassThroughOff()
		{
			vtkCollectGraph.vtkCollectGraph_PassThroughOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_PassThroughOn_10(HandleRef pThis);

		public virtual void PassThroughOn()
		{
			vtkCollectGraph.vtkCollectGraph_PassThroughOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectGraph_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollectGraph SafeDownCast(vtkObjectBase o)
		{
			vtkCollectGraph vtkCollectGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectGraph.vtkCollectGraph_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectGraph = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectGraph.Register(null);
				}
			}
			return vtkCollectGraph;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_SetController_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkCollectGraph.vtkCollectGraph_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_SetOutputType_13(HandleRef pThis, int _arg);

		public virtual void SetOutputType(int _arg)
		{
			vtkCollectGraph.vtkCollectGraph_SetOutputType_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_SetPassThrough_14(HandleRef pThis, int _arg);

		public virtual void SetPassThrough(int _arg)
		{
			vtkCollectGraph.vtkCollectGraph_SetPassThrough_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCollectGraph_SetSocketController_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetSocketController(vtkSocketController arg0)
		{
			vtkCollectGraph.vtkCollectGraph_SetSocketController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
