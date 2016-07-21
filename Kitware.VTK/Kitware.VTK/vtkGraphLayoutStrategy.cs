using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGraphLayoutStrategy : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkGraphLayoutStrategy()
		{
			vtkGraphLayoutStrategy.MRClassNameKey = "class vtkGraphLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutStrategy"));
		}

		public vtkGraphLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutStrategy_GetEdgeWeightField_01(HandleRef pThis);

		public virtual string GetEdgeWeightField()
		{
			return Marshal.PtrToStringAnsi(vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetEdgeWeightField_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkGraphLayoutStrategy_GetWeightEdges_02(HandleRef pThis);

		public virtual bool GetWeightEdges()
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetWeightEdges_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutStrategy_Initialize_03(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_Initialize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutStrategy_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutStrategy_IsLayoutComplete_05(HandleRef pThis);

		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsLayoutComplete_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutStrategy_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutStrategy_Layout_07(HandleRef pThis);

		public virtual void Layout()
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_Layout_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphLayoutStrategy NewInstance()
		{
			vtkGraphLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutStrategy_SetEdgeWeightField_10(HandleRef pThis, string field);

		public virtual void SetEdgeWeightField(string field)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetEdgeWeightField_10(base.GetCppThis(), field);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutStrategy_SetGraph_11(HandleRef pThis, HandleRef graph);

		public virtual void SetGraph(vtkGraph graph)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetGraph_11(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutStrategy_SetWeightEdges_12(HandleRef pThis, byte state);

		public virtual void SetWeightEdges(bool state)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetWeightEdges_12(base.GetCppThis(), state ? (byte)1 : (byte)0);
		}
	}
}
