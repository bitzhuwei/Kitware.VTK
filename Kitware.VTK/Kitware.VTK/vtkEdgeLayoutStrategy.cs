using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkEdgeLayoutStrategy : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkEdgeLayoutStrategy()
		{
			vtkEdgeLayoutStrategy.MRClassNameKey = "class vtkEdgeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeLayoutStrategy"));
		}

		public vtkEdgeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(HandleRef pThis);

		public virtual string GetEdgeWeightArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeLayoutStrategy_Initialize_02(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_Initialize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeLayoutStrategy_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeLayoutStrategy_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeLayoutStrategy_Layout_05(HandleRef pThis);

		public virtual void Layout()
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_Layout_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayoutStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgeLayoutStrategy NewInstance()
		{
			vtkEdgeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeLayoutStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_08(HandleRef pThis, string _arg);

		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeLayoutStrategy_SetGraph_09(HandleRef pThis, HandleRef graph);

		public virtual void SetGraph(vtkGraph graph)
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SetGraph_09(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}
	}
}
