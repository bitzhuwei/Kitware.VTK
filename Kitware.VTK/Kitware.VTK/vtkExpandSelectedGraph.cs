using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExpandSelectedGraph : vtkSelectionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExpandSelectedGraph";

		public new static readonly string MRClassNameKey;

		static vtkExpandSelectedGraph()
		{
			vtkExpandSelectedGraph.MRClassNameKey = "class vtkExpandSelectedGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExpandSelectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExpandSelectedGraph"));
		}

		public vtkExpandSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExpandSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExpandSelectedGraph New()
		{
			vtkExpandSelectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExpandSelectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExpandSelectedGraph.vtkExpandSelectedGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExpandSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExpandSelectedGraph_GetBFSDistance_02(HandleRef pThis);

		public virtual int GetBFSDistance()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetBFSDistance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExpandSelectedGraph_GetDomain_03(HandleRef pThis);

		public virtual string GetDomain()
		{
			return Marshal.PtrToStringAnsi(vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetDomain_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkExpandSelectedGraph_GetIncludeShortestPaths_04(HandleRef pThis);

		public virtual bool GetIncludeShortestPaths()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetIncludeShortestPaths_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkExpandSelectedGraph_GetUseDomain_05(HandleRef pThis);

		public virtual bool GetUseDomain()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetUseDomain_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOff_06(HandleRef pThis);

		public virtual void IncludeShortestPathsOff()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_IncludeShortestPathsOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOn_07(HandleRef pThis);

		public virtual void IncludeShortestPathsOn()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_IncludeShortestPathsOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExpandSelectedGraph_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExpandSelectedGraph_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExpandSelectedGraph_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExpandSelectedGraph NewInstance()
		{
			vtkExpandSelectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExpandSelectedGraph_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExpandSelectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkExpandSelectedGraph vtkExpandSelectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExpandSelectedGraph = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExpandSelectedGraph.Register(null);
				}
			}
			return vtkExpandSelectedGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_SetBFSDistance_13(HandleRef pThis, int _arg);

		public virtual void SetBFSDistance(int _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetBFSDistance_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_SetDomain_14(HandleRef pThis, string _arg);

		public virtual void SetDomain(string _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetDomain_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_SetGraphConnection_15(HandleRef pThis, HandleRef arg0);

		public void SetGraphConnection(vtkAlgorithmOutput arg0)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetGraphConnection_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_SetIncludeShortestPaths_16(HandleRef pThis, byte _arg);

		public virtual void SetIncludeShortestPaths(bool _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetIncludeShortestPaths_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_SetUseDomain_17(HandleRef pThis, byte _arg);

		public virtual void SetUseDomain(bool _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetUseDomain_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_UseDomainOff_18(HandleRef pThis);

		public virtual void UseDomainOff()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_UseDomainOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExpandSelectedGraph_UseDomainOn_19(HandleRef pThis);

		public virtual void UseDomainOn()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_UseDomainOn_19(base.GetCppThis());
		}
	}
}
