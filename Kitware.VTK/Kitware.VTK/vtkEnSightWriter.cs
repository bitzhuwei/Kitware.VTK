using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSightWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightWriter";

		public new static readonly string MRClassNameKey;

		static vtkEnSightWriter()
		{
			vtkEnSightWriter.MRClassNameKey = "class vtkEnSightWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightWriter"));
		}

		public vtkEnSightWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightWriter New()
		{
			vtkEnSightWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSightWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSightWriter.vtkEnSightWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetBaseName_01(HandleRef pThis);

		public virtual string GetBaseName()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetBaseName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetBlockIDs_02(HandleRef pThis);

		public virtual IntPtr GetBlockIDs()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetBlockIDs_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_GetGhostLevel_04(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetGhostLevel_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new virtual vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_GetInput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetModelMetadata_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkModelMetadata GetModelMetadata()
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_GetModelMetadata_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_GetNumberOfBlocks_07(HandleRef pThis);

		public virtual int GetNumberOfBlocks()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetNumberOfBlocks_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_GetPath_08(HandleRef pThis);

		public virtual string GetPath()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetPath_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_GetProcessNumber_09(HandleRef pThis);

		public virtual int GetProcessNumber()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetProcessNumber_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_GetTimeStep_10(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetTimeStep_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkEnSightWriter_GetTransientGeometry_11(HandleRef pThis);

		public virtual bool GetTransientGeometry()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetTransientGeometry_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkEnSightWriter_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSightWriter NewInstance()
		{
			vtkEnSightWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightWriter SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightWriter vtkEnSightWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightWriter = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightWriter.Register(null);
				}
			}
			return vtkEnSightWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetBaseName_17(HandleRef pThis, string _arg);

		public virtual void SetBaseName(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetBaseName_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetBlockIDs_18(HandleRef pThis, IntPtr val);

		public virtual void SetBlockIDs(IntPtr val)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetBlockIDs_18(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetFileName_19(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetFileName_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetGhostLevel_20(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetGhostLevel_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetInput_21(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkUnstructuredGrid input)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetInput_21(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetModelMetadata_22(HandleRef pThis, HandleRef model);

		public virtual void SetModelMetadata(vtkModelMetadata model)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetModelMetadata_22(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetNumberOfBlocks_23(HandleRef pThis, int _arg);

		public virtual void SetNumberOfBlocks(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetNumberOfBlocks_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetPath_24(HandleRef pThis, string _arg);

		public virtual void SetPath(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetPath_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetProcessNumber_25(HandleRef pThis, int _arg);

		public virtual void SetProcessNumber(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetProcessNumber_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetTimeStep_26(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetTimeStep_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_SetTransientGeometry_27(HandleRef pThis, byte _arg);

		public virtual void SetTransientGeometry(bool _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetTransientGeometry_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_WriteCaseFile_28(HandleRef pThis, int TotalTimeSteps);

		public virtual void WriteCaseFile(int TotalTimeSteps)
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteCaseFile_28(base.GetCppThis(), TotalTimeSteps);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkEnSightWriter_WriteSOSCaseFile_29(HandleRef pThis, int NumProcs);

		public virtual void WriteSOSCaseFile(int NumProcs)
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteSOSCaseFile_29(base.GetCppThis(), NumProcs);
		}
	}
}
