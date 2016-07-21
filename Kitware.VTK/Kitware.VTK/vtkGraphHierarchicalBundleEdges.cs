using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphHierarchicalBundleEdges : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphHierarchicalBundleEdges";

		public new static readonly string MRClassNameKey;

		static vtkGraphHierarchicalBundleEdges()
		{
			vtkGraphHierarchicalBundleEdges.MRClassNameKey = "class vtkGraphHierarchicalBundleEdges";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphHierarchicalBundleEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphHierarchicalBundleEdges"));
		}

		public vtkGraphHierarchicalBundleEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphHierarchicalBundleEdges New()
		{
			vtkGraphHierarchicalBundleEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphHierarchicalBundleEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(HandleRef pThis);

		public virtual void DirectMappingOff()
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(HandleRef pThis);

		public virtual void DirectMappingOn()
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(HandleRef pThis);

		public virtual double GetBundlingStrength()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(HandleRef pThis);

		public virtual double GetBundlingStrengthMaxValue()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(HandleRef pThis);

		public virtual double GetBundlingStrengthMinValue()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(HandleRef pThis);

		public virtual bool GetDirectMapping()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundleEdges_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphHierarchicalBundleEdges_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphHierarchicalBundleEdges NewInstance()
		{
			vtkGraphHierarchicalBundleEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphHierarchicalBundleEdges SafeDownCast(vtkObjectBase o)
		{
			vtkGraphHierarchicalBundleEdges vtkGraphHierarchicalBundleEdges = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphHierarchicalBundleEdges = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphHierarchicalBundleEdges.Register(null);
				}
			}
			return vtkGraphHierarchicalBundleEdges;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundleEdges_SetBundlingStrength_13(HandleRef pThis, double _arg);

		public virtual void SetBundlingStrength(double _arg)
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SetBundlingStrength_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphHierarchicalBundleEdges_SetDirectMapping_14(HandleRef pThis, byte _arg);

		public virtual void SetDirectMapping(bool _arg)
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SetDirectMapping_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
