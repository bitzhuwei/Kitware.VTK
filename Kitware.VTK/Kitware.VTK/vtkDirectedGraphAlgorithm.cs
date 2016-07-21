using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDirectedGraphAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectedGraphAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkDirectedGraphAlgorithm()
		{
			vtkDirectedGraphAlgorithm.MRClassNameKey = "class vtkDirectedGraphAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectedGraphAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectedGraphAlgorithm"));
		}

		public vtkDirectedGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedGraphAlgorithm New()
		{
			vtkDirectedGraphAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDirectedGraphAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDirectedGraph GetOutput()
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_GetOutput_02(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDirectedGraph GetOutput(int index)
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetOutput_02(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDirectedGraphAlgorithm_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDirectedGraphAlgorithm_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDirectedGraphAlgorithm NewInstance()
		{
			vtkDirectedGraphAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedGraphAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkDirectedGraphAlgorithm vtkDirectedGraphAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraphAlgorithm = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraphAlgorithm.Register(null);
				}
			}
			return vtkDirectedGraphAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDirectedGraphAlgorithm_SetInput_08(HandleRef pThis, HandleRef obj);

		public void SetInput(vtkDataObject obj)
		{
			vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SetInput_08(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDirectedGraphAlgorithm_SetInput_09(HandleRef pThis, int index, HandleRef obj);

		public void SetInput(int index, vtkDataObject obj)
		{
			vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SetInput_09(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}
	}
}
