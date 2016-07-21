using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkGraphAlgorithm()
		{
			vtkGraphAlgorithm.MRClassNameKey = "class vtkGraphAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphAlgorithm"));
		}

		public vtkGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphAlgorithm New()
		{
			vtkGraphAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphAlgorithm.vtkGraphAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphAlgorithm_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphAlgorithm_GetOutput_02(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetOutput(int index)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_GetOutput_02(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphAlgorithm_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphAlgorithm_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphAlgorithm NewInstance()
		{
			vtkGraphAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkGraphAlgorithm vtkGraphAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphAlgorithm = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphAlgorithm.Register(null);
				}
			}
			return vtkGraphAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraphAlgorithm_SetInput_08(HandleRef pThis, HandleRef obj);

		public void SetInput(vtkDataObject obj)
		{
			vtkGraphAlgorithm.vtkGraphAlgorithm_SetInput_08(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraphAlgorithm_SetInput_09(HandleRef pThis, int index, HandleRef obj);

		public void SetInput(int index, vtkDataObject obj)
		{
			vtkGraphAlgorithm.vtkGraphAlgorithm_SetInput_09(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}
	}
}
